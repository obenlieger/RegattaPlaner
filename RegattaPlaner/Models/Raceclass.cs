using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class Raceclass
    {
        [Key]
        public virtual int RaceclassId { get; set; }
        [Display(Name = "Rennklassenname")]
        public virtual string Name { get; set; }
        [Display(Name = "Streckenlänge")]
        public virtual int Length { get; set; }
        public virtual List<Race> Races { get; set; }
        public virtual List<Competition> Competitions { get; set; }
    }
}
