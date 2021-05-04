﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Core.DTOs.Request
{
   public class SponsorExhibitorRequest
    {
        public int SponsorExhibitorId { get; set; }
        public int SponsorId { get; set; }
        public int ExhibitorId { get; set; }
        public int SponsorTypeId { get; set; }
        public int? AdTypeId { get; set; }
        public string TypeId { get; set; }
        public decimal SponsorAmount { get; set; }
        public int HorseId { get; set; }

    }
  
}
