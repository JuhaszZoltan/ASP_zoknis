using ASP_MVC_Template_FW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_Template_FW.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        public ActionResult Index()
        {
            return View(_context.Zoknik.ToList());
        }
        public ActionResult Zoknik()
        {
            return View(_context.Zoknik.ToList());
        }
        //[Authorize]
        public ActionResult Kolcsonzok()
        {
            return View(_context.Kolcsonzok.ToList());
        }

        public ActionResult KolcsonzoForm()
        {
            return View(new Kolcsonzo() { KolcsonzoId = 0, NoKolcsonzes = 0});
        }

        public ActionResult Rolunk()
        {
            return View();
        }

        public ActionResult Like(int id)
        {
            var zokniInDb = _context.Zoknik.SingleOrDefault(x => x.ZokniId == id);
            if (zokniInDb == null) return HttpNotFound();
            zokniInDb.Like += 1;
            _context.SaveChanges();
            return RedirectToAction("Zoknik");
        }
        public ActionResult Dislike(int id)
        {
            var zokniInDb = _context.Zoknik.SingleOrDefault(x => x.ZokniId == id);
            if (zokniInDb == null) return HttpNotFound();
            zokniInDb.DisLike += 1;
            _context.SaveChanges();
            return RedirectToAction("Zoknik");
        }

        [HttpPost]
        public ActionResult UjKolcsonzo(Kolcsonzo kolcsonzo)
        {
            if (!ModelState.IsValid)
            {
                return View("KolcsonzoForm", kolcsonzo);
            }
            _context.Kolcsonzok.Add(kolcsonzo);
            _context.SaveChanges();
            return RedirectToAction("Kolcsonzok");
        }
    }
}