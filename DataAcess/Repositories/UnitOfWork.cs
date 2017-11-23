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

        public DbContext Context;
        private Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        
        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public IRepository<T> Repository<T>() where T:class,IEntity,new()
        {
            if (repositories.Keys.Contains(typeof(T)) == true)
            {
                return repositories[typeof(T)] as IRepository<T>;
            }
            IRepository<T> repo = RepoContainer.container.Resolve<IRepository<T>>(new ParameterOverride("context",Context));
            repositories.Add(typeof(T), repo);
            return repo;
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
