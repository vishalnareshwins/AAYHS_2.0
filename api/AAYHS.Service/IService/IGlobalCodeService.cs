﻿using AAYHS.Core.DTOs.Request;
using AAYHS.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AAYHS.Service.IService
{
    public interface IGlobalCodeService
    {
        MainResponse GetGlobalCode(string globalCodeType);
        MainResponse GetAllStates();
        MainResponse GetAllCities(int StateId);
        MainResponse GetAllZipCodes(ZipCodeRequest request);
    }
}
