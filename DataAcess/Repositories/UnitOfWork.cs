using System;
using Models;
using Interfaces;

namespace Repositories
{
    public class UnitOfWork : IDisposable , IUnitOfWork
    {

        private bool disposed = false;

        private WebStoreContext context;
        private BaseRepository<Laptop> laptopRepo;
        private BaseRepository<PC> pcRepo;

        public WebStoreContext Context
        {
            get { return this.context ?? (context = new WebStoreContext()); }
        }

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
