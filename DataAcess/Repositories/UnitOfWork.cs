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

        private DbContext Context;
        private Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        
        public UnitOfWork(DbContext context)
        {
            //RepoInjector injector = new RepoInjector();
            Context = context;
        }

        public IRepository<T> Repository<T>() where T:class,IEntity,new()
        {
            if (repositories.Keys.Contains(typeof(T)) == true)
            {
                return repositories[typeof(T)] as IRepository<T>;
            }

            IRepository<T> repo = new BaseRepository<T>(Context);
            repositories.Add(typeof(T), repo);
            return repo;
        }
        //public DbContext Context
        //{
        //    get { return this.context; }
        //}

        //public Context Context
        //{
        //    get { return this.context ?? (); }
        //}

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
