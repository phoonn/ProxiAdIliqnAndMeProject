using System;
using Models;

namespace Repositories
{
    public class UnitOfWork : IDisposable
    {

        private bool disposed = false;

        private WebStoreContext context = new WebStoreContext();
        private BaseRepository<Laptop> laptopRepo;
        private BaseRepository<PC> pcRepo;


        public BaseRepository<Laptop> LaptopRepo
        {
            get
            {
                return this.laptopRepo ?? new BaseRepository<Laptop>(context);
            }
        }

        public BaseRepository<PC> PcRepo
        {
            get
            {
                return this.pcRepo ?? new BaseRepository<PC>(context);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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
