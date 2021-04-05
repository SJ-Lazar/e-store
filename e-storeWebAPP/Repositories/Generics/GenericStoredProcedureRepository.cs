using Dapper;
using DataAccessLayer.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Repositories.Generics
{
    public class GenericStoredProcedureRepository : IGenericStoredProcedureRepository
    {
        private readonly eStoreDbContext _context;
        private static string ConnectionString = "";

        public GenericStoredProcedureRepository(eStoreDbContext context)
        {
            _context = context;
            ConnectionString = _context.Database.GetDbConnection().ConnectionString;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<T> ExecutetReturnScalar<T>(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                await sqlConnection.OpenAsync();

                return await (Task<T>)Convert.ChangeType(sqlConnection.ExecuteScalarAsync<Task<T>>(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }

        public async void ExecuteWithoutReturn(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                await sqlConnection.OpenAsync();

                await sqlConnection.ExecuteAsync(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<T>> ReturnList<T>(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                await sqlConnection.OpenAsync();

                return await sqlConnection.QueryAsync<T>(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
