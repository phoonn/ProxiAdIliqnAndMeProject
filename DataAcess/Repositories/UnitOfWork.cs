using System;
using Models;
using Interfaces;
using System.Data.Entity;
using Unity;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class UnitOfWork : IDisposable , IUnitOfWork 
    {

        private bool disposed = false;

        public DbContext Context { get; private set; }
        
        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}
