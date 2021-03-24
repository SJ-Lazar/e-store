using DataDomain.DataTables.Books;
using e_storeWebAPP.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Repositories.UnitsofWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Book> Books { get; }
        Task Save();
    }
}
