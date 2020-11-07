using ApplicationCore.Interfaces.Library;
using Infrastructure.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Library
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly SampleContext _context;

        public EfUnitOfWork(SampleContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _context.Database.RollbackTransaction();
        }
    }
}
