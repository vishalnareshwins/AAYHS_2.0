﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AAYHS.Repository.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T Get<Tkey>(T id);
        List<T> GetAll();
        T Add(T entity);
        void Update(T entity);
        T GetSingle(Expression<Func<T, bool>> whereCondition);
        List<T> GetAll(Expression<Func<T, bool>> whereCondition);
        void Delete(T entity);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task SPExecuteNonQueryAsync(DynamicParameters dynamicParameters, String StorePorcedureName);
        Task<string> SPReadDataListAsync(DynamicParameters dynamicParameters, String StorePorcedureName);
        Task<string> SPReadSingleDataAsync(DynamicParameters dynamicParameters, String StorePorcedureName);
        List<T> GetRecordsWithFilters(int page, int limit, string orderBy, bool orderByDescending, bool AllRecords);
        List<T> GetRecordsWithFilters(int page, int limit, string orderBy, bool orderByDescending, bool AllRecords, Expression<Func<T, bool>> whereCondition = null);
        int GetTotalCount();
        int GetTotalCount(Expression<Func<T, bool>> whereCondition);
    }
}
