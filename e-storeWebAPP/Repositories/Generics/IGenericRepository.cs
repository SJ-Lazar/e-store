using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace e_storeWebAPP.Repositories.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        #region Generic CRUD Operation Methods
        Task<IList<T>> GetAll(
           Expression<Func<T, bool>> expression = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           List<string> includes = null);
        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);


        TResult GetFirstOrDefault<TResult>(Expression<Func<T, TResult>> selector,
                                         Expression<Func<T, bool>> predicate = null,
                                         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                         bool disableTracking = true);


        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity); 
        #endregion
    }
}
