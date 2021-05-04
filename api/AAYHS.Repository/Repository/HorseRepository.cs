﻿using AAYHS.Core.DTOs.Request;
using AAYHS.Core.DTOs.Response;
using AAYHS.Core.DTOs.Response.Common;
using AAYHS.Data.DBContext;
using AAYHS.Data.DBEntities;
using AAYHS.Repository.IRepository;
using AutoMapper;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Repository.Repository
{
    public class HorseRepository: GenericRepository<Horses>, IHorseRepository
    {

        #region readonly
        private readonly AAYHSDBContext _ObjContext;
        private IMapper _Mapper;
        #endregion

        #region private 
        private MainResponse _MainResponse;
        #endregion

        public HorseRepository(AAYHSDBContext ObjContext, IMapper Mapper) : base(ObjContext)
        {
            _ObjContext = ObjContext;
            _Mapper = Mapper;
            _MainResponse = new MainResponse();
        }
        public GetAllHorses GetAllHorses(HorseRequest horseRequest)
        {
            IEnumerable<HorseResponse> data;
            GetAllHorses getAllHorses = new GetAllHorses();

            data = (from horse in _ObjContext.Horses
                    where horse.IsActive == true && horse.IsDeleted == false
                    select new HorseResponse 
                    {
                        HorseId=horse.HorseId,
                        Name=horse.Name,
                        HorseType=_ObjContext.GlobalCodes.Where(x=>x.GlobalCodeId==horse.HorseTypeId).Select(x=>x.CodeName).FirstOrDefault()                       
                    });

            if (data.Count() != 0)
            {
                if (horseRequest.SearchTerm!=null && horseRequest.SearchTerm!="")
                {
                    data = data.Where(x => Convert.ToString(x.HorseId).Contains(horseRequest.SearchTerm) || x.Name.ToLower().Contains(horseRequest.SearchTerm.ToLower()) ||
                                     x.HorseType.ToLower().Contains(horseRequest.SearchTerm.ToLower()));
                }
                if (horseRequest.OrderByDescending == true)
                {
                    data = data.OrderByDescending(x => x.GetType().GetProperty(horseRequest.OrderBy).GetValue(x));
                }
                else
                {
                    data = data.OrderBy(x => x.GetType().GetProperty(horseRequest.OrderBy).GetValue(x));
                }
                getAllHorses.TotalRecords = data.Count();
                if (horseRequest.AllRecords)
                {
                    getAllHorses.horsesResponse = data.ToList();
                }
                else
                {
                    getAllHorses.horsesResponse = data.Skip((horseRequest.Page - 1) * horseRequest.Limit).Take(horseRequest.Limit).ToList();

                }

            }
            return getAllHorses;
        }              
        public GetAllLinkedExhibitors LinkedExhibitors(HorseExhibitorRequest horseExhibitorRequest)
        {
            IEnumerable<GetLinkedExhibitors> data;
            GetAllLinkedExhibitors getAllLinkedExhibitors = new GetAllLinkedExhibitors();

            data = (from exhibitorHorse in _ObjContext.ExhibitorHorse
                    join exhibitor in _ObjContext.Exhibitors on exhibitorHorse.ExhibitorId equals exhibitor.ExhibitorId into exhibitor1
                    from exhibitor2 in exhibitor1.DefaultIfEmpty()
                    where exhibitorHorse.HorseId == horseExhibitorRequest.HorseId && exhibitorHorse.IsActive == true && exhibitorHorse.IsDeleted == false
                    && exhibitor2.IsActive==true & exhibitor2.IsDeleted==false
                    select new GetLinkedExhibitors 
                    { 
                       ExhibitorId= exhibitorHorse.ExhibitorId,
                       ExhibitorName=exhibitor2.FirstName+" "+exhibitor2.LastName,
                       BirthYear=exhibitor2.BirthYear

                    });
            if (data.Count() != 0)
            {
                if (horseExhibitorRequest.OrderByDescending == true)
                {
                    data = data.OrderByDescending(x => x.GetType().GetProperty(horseExhibitorRequest.OrderBy).GetValue(x));
                }
                else
                {
                    data = data.OrderBy(x => x.GetType().GetProperty(horseExhibitorRequest.OrderBy).GetValue(x));
                }
                getAllLinkedExhibitors.TotalRecords = data.Count();
                if (horseExhibitorRequest.AllRecords)
                {
                    getAllLinkedExhibitors.getLinkedExhibitors = data.ToList();
                }
                else
                {
                    getAllLinkedExhibitors.getLinkedExhibitors = data.Skip((horseExhibitorRequest.Page - 1) * horseExhibitorRequest.Limit).Take(horseExhibitorRequest.Limit).ToList();

                }

            }
            return getAllLinkedExhibitors;
        }
    }
}
