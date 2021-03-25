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
        #region Generic Injection Propertise
        IGenericRepository<Book> Books { get; }
        IGenericRepository<Invoice> Invoices { get; }
        IGenericRepository<Receipt> Receipts { get; }
        #endregion

        #region UOW Methods
        Task Save(); 
        #endregion
    }
}
