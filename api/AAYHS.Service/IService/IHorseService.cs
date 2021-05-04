﻿
using AAYHS.Core.DTOs.Request;
using AAYHS.Core.DTOs.Response;
using AAYHS.Core.DTOs.Response.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Service.IService
{
    public interface IHorseService
    {
        MainResponse GetAllHorses(HorseRequest horseRequest);
        MainResponse GetHorse(int HorseId);
        MainResponse RemoveHorse(int HorseId, string actionBy);
        MainResponse AddUpdateHorse(HorseAddRequest horseAddRequest, string actionBy);       
        MainResponse LinkedExhibitors(HorseExhibitorRequest horseExhibitorRequest);
        MainResponse GetGroups();
    }
}
