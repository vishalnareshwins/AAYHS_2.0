﻿using AAYHS.Core.DTOs.Request;
using AAYHS.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AAYHS.Service.IService
{
    public interface IClassService
    {
        MainResponse GetAllClasses(ClassRequest classRequest);
        MainResponse GetClass(int ClassId);
        MainResponse GetClassExhibitors(int ClassId);
        MainResponse GetExhibitorHorses(int ExhibitorId);
        MainResponse GetClassExhibitorsAndHorses(int ClassId);
        Task<MainResponse> CreateUpdateClass(AddClassRequest addClassRequest, string actionBy);
        Task<MainResponse> AddExhibitorToClass(AddClassExhibitor addClassExhibitor, string actionBy);      
        MainResponse GetClassEntries(ClassRequest classRequest);
        Task<MainResponse> DeleteClassExhibitor(int ExhibitorClassId, string actionBy);
        Task<MainResponse> RemoveClass(int ClassId, string actionBy);       
        MainResponse GetBackNumberForAllExhibitor(int ClassId);
        MainResponse GetResultExhibitorDetails(ResultExhibitorRequest resultExhibitorRequest);
        Task<MainResponse> AddClassResult(AddClassResultRequest addClassResultRequest, string actionBy);
        MainResponse GetResultOfClass(ClassRequest classRequest);       
        MainResponse UpdateClassExhibitorScratch(ClassExhibitorScratch classExhibitorScratch, string actionBy);
        MainResponse UpdateClassResult(UpdateClassResult updateClassResult, string actionBy);
        MainResponse DeleteClassResult(int resultId, string actionBy);
    }
}
