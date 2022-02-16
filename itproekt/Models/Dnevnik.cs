using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace itproekt.Models
{
    public class Dnevnik
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Датум кога е одржана наставата")]
        public DateTime datum { get; set; }
        [Required]
        [Display(Name = "Предмет и опис на прв час")]
        public string prvcas { get; set; }
        [Required]
        [Display(Name = "Предмет и опис на втор час")]
        public string vtorcas { get; set; }
        [Display(Name = "Предмет и опис на трет час")]
        public string tretcas { get; set; }
        [Display(Name = "Предмет и опис на четврти час")]
        public string cetvrticas { get; set; }
        [Display(Name = "Предмет и опис на петти час")]
        public string petticas { get; set; }
    }
}
