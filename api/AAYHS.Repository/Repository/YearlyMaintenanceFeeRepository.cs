﻿using AAYHS.Core.DTOs.Response;
using AAYHS.Data.DBContext;
using AAYHS.Data.DBEntities;
using AAYHS.Repository.IRepository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Repository.Repository
{
    public class YearlyMaintenanceFeeRepository:GenericRepository<YearlyMaintainenceFee>, IYearlyMaintenanceFeeRepository
    {
        #region readonly
        private readonly AAYHSDBContext _ObjContext;
        private IMapper _Mapper;
        #endregion

        #region private 
        private MainResponse _MainResponse;
        #endregion

        public YearlyMaintenanceFeeRepository(AAYHSDBContext ObjContext,IMapper Mapper) : base(ObjContext)
        {
            _ObjContext = ObjContext;
            _Mapper = Mapper;
            _MainResponse = new MainResponse();
        }
    }
}
