using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class Oldclass
    {
        [Key]
        public virtual int OldclassId { get; set; }
        [Display(Name = "Altersklassenname")]
        public virtual string Name { get; set; }
        [Display(Name = "Von Alter")]
        public virtual int FromAge { get; set; }
        [Display(Name = "Bis Alter")]
        public virtual int ToAge { get; set; }
        public virtual List<Race> Races { get; set; }
        public virtual List<RegattaOldclass> RegattaOldclasses { get; set; }
        public virtual List<ReportedRace> ReportedRaces { get; set; }
    }
}
