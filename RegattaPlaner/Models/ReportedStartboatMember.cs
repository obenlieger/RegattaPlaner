﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class ReportedStartboatMember
    {
        public int ReportedStartboatId { get; set; }
        public ReportedStartboat ReportedStartboat { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int Seatnumber { get; set; }
    }
}
