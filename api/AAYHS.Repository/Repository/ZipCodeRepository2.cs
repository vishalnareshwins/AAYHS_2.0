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
    public class ZipCodeRepository2 : GenericRepository<ZipCodes2>, IZipCodeRepository2
    {
        #region readonly
        private readonly IMapper _Mapper;
        #endregion

        #region Private
        private MainResponse _MainResponse;
        #endregion

        #region public
        public AAYHSDBContext _context;
        #endregion

        public ZipCodeRepository2(AAYHSDBContext ObjContext, IMapper Mapper) : base(ObjContext)
        {
            _MainResponse = new MainResponse();
            _context = ObjContext;
            _Mapper = Mapper;
        }



    }
}
