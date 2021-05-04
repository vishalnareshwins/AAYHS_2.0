﻿using AAYHS.Core.DTOs.Request;
using AAYHS.Core.DTOs.Response;
using AAYHS.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Repository.IRepository
{
   public interface ISponsorDistributionRepository : IGenericRepository<SponsorDistributions>
    {
        MainResponse GetSponsorDistributionBySponsorId(int SponsorId);
    }
}
