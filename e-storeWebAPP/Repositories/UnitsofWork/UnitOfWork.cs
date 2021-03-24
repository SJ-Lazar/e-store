using DataAccessLayer.Context;
using DataDomain.DataTables.Books;
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
        #endregion

        #region Constructor
        public UnitOfWork(eStoreDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Book> Books => _books ??= new GenericRepository<Book>(_context);
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
