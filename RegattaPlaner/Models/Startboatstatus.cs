using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class Startboatstatus
    {
        [Key]
        public virtual int StartboatstatusId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Startboat> Startboats { get; set; }
    }
}
