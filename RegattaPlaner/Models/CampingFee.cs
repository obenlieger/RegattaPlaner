﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class CampingFee
    {
        [Key]
        public virtual int CampingFeeId { get; set; }
        public virtual string Name { get; set; }
        [Display(Name = "Gebühr")]
        public virtual float Amount { get; set; }
        public virtual string LongName
        {
            get
            {
                return string.Format("{0} = {1} EUR", Name, Amount);
            }
        }
        public virtual List<RegattaCampingFee> RegattaCampingFees { get; set; }
        public virtual List<ClubCampingFee> ClubCampingFees { get; set; }
    }
}
