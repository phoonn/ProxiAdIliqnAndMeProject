using System;
using Models;
using Interfaces;
using System.Data.Entity;
using Unity;
using Microsoft.Practices.Unity;


namespace Repositories
{
    public class UnitOfWork : IDisposable , IUnitOfWork 
    {

        private bool disposed = false;

        private DbContext Context;
        //private DbContext context;
        private BaseRepository<Laptop> laptopRepo;
        private BaseRepository<PC> pcRepo;

        public UnitOfWork()
        {
            RepoInjector injector = new RepoInjector();
            Context = injector.container.Resolve<WebStoreContext>();
        }

        //public DbContext Context
        //{
        //    get { return this.context; }
        //}

        //public Context Context
        //{
        //    get { return this.context ?? (); }
        //}

        public BaseRepository<Laptop> LaptopRepo
        {
            get
            {
                return this.laptopRepo ?? (laptopRepo =new BaseRepository<Laptop>(Context));
            }
        }

        public BaseRepository<PC> PcRepo
        {
            get
            {
                return this.pcRepo ?? (pcRepo =  new BaseRepository<PC>(Context));
            }
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
