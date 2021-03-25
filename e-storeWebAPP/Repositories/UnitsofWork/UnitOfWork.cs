using DataAccessLayer.Context;
using DataDomain.DataTables.Books;
using DataDomain.DataTables.Transactions;
using e_storeWebAPP.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Repositories.UnitsofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private Variables
        private readonly eStoreDbContext _context;
        private IGenericRepository<Book> _books;
        private IGenericRepository<Invoice> _invoices;
        private IGenericRepository<Receipt> _receipts;
        #endregion

        #region Constructor
        public UnitOfWork(eStoreDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Book> Books => _books ??= new GenericRepository<Book>(_context);

        public IGenericRepository<Invoice> Invoices => _invoices ??= new GenericRepository<Invoice>(_context);

        public IGenericRepository<Receipt> Receipts => _receipts ??= new GenericRepository<Receipt>(_context);
        #endregion

        #region UOW Methods
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        } 
        #endregion
    }
}
