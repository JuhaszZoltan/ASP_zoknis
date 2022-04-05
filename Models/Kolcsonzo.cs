using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP_MVC_Template_FW.Models
{
    [Table("Kolcsonzok")]
    public class Kolcsonzo
    {
        [Key]
        public int KolcsonzoId { get; set; }
        [Required(ErrorMessage = "A név megadása kötelező")]
        public string Nev { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "e-mail cyím megadása kötelező")]
        public string Email { get; set; }
        public int NoKolcsonzes { get; set; }

    }
}