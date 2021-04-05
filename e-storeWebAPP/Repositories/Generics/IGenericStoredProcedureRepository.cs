using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Repositories.Generics
{
    public interface IGenericStoredProcedureRepository
    {
        Task<IEnumerable<T>> ReturnList<T>(string procedureName, DynamicParameters parameters = null);
        void ExecuteWithoutReturn(string procedureName, DynamicParameters parameters = null);
        Task<T> ExecutetReturnScalar<T>(string procedureName, DynamicParameters parameters = null);
    }
}
