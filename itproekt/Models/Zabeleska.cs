using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace itproekt.Models
{
    public class Zabeleska
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Датум")]
        public DateTime datum { get; set; }
        [Display(Name = "Забелешка")]
        public string zabeleska { get; set; }
    }
}