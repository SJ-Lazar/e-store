using DataDomain.DataTables.Books;
using DataDomain.DataTables.Transactions;
using e_storeWebAPP.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Repositories.UnitsofWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericStoredProcedureRepository GenericStoredProcedure { get; }
        void Save();
    }
}
