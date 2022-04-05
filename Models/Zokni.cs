using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP_MVC_Template_FW.Models
{
    [Table("Zoknik")]
    public class Zokni
    {
        [Key]
        public int ZokniId { get; set; }
        public string Tipus { get; set; }
        public int Keszlet { get; set; }
        public int Like { get; set; }
        public int DisLike { get; set; }
        public string Kep { get; set; }


    }
}