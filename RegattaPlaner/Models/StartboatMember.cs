﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class StartboatMember
    {
        public int StartboatId { get; set; }
        public Startboat Startboat { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int SeatNumber { get; set; }
    }
}
