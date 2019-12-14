using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class RegattaCampingFee
    {
        public virtual int CampingFeeId { get; set; }
        public virtual CampingFee CampingFees { get; set; }
        public virtual int RegattaId { get; set; }
        public virtual Regatta Regattas { get; set; }
    }
}
