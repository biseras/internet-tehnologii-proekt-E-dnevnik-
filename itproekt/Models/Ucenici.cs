using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace itproekt.Models
{
    public class Ucenici
    {
        [Key]
        [Display(Name = "Број во дневник")]
        public int broj { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Име на ученикот")]
        public string name { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Презиме на ученикот")]
        public string prezime { get; set; }
        [Range(1, 5)]
        [Display(Name = "Оценка по македонски")]
        public int makedonski { get; set; }
        [Display(Name = "Оценка по математика")]
        public int matematika { get; set; }
        [Range(1, 5)]
        [Display(Name = "Оценка по англиски")]
        public int angliski { get; set; }
        [Range(1, 5)]
        [Display(Name = "Оценка по природни науки")]
        public int prirodninauki { get; set; }
        [Range(1, 5)]
        [Display(Name = "Оценка по музичко")]
        public int muzicko { get; set; }
        [Range(1, 5)]
        [Display(Name = "Оценка по физичко")]
        public int fizicko { get; set; }
        [Range(1, 5)]
        [Display(Name = "Оценка по ликовно")]
        public int likovno { get; set; }
        [Range(0, 100)]
        [Display(Name = "Отсуство од час")]
        public int izostanoci { get; set; }
    }
}