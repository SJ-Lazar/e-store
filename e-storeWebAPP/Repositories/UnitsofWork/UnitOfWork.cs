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
        private readonly eStoreDbContext _context;

        public UnitOfWork(eStoreDbContext context)
        {
            _context = context;
            GenericStoredProcedure = new GenericStoredProcedureRepository(_context);
        }

        public IGenericStoredProcedureRepository GenericStoredProcedure { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async void Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
