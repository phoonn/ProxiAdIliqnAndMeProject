using System.Collections.Generic;
using Models;
using System.Linq.Expressions;
using System;
using System.Linq;
using Interfaces;

namespace BusinessServices
{
    public class LaptopsLogic : ICrudLogic<Laptops> , IDisposable
    {
        private IUnitOfWork Unit;
        private IRepository<Laptops> LaptopRepo;

        private bool disposed = false;

        public LaptopsLogic(IRepository<Laptops> laptopRepo,IUnitOfWork unit)
        {
            Unit = unit;
            LaptopRepo = laptopRepo;
        }
        
        public void Create(Laptops laptop)
        {
            LaptopRepo.Insert(laptop);
            Unit.Save();
        }

        public void Delete(Laptops laptop)
        {
            LaptopRepo.Delete(laptop);
            Unit.Save();
        }

        public void DeleteById(int id)
        {
            LaptopRepo.Delete(id);
            Unit.Save();
        }

        public IEnumerable<Laptops> GetAll(
            Expression<Func<Laptops, bool>> filter = null,
            Func<IQueryable<Laptops>, IOrderedQueryable<Laptops>> orderBy = null,
            string includeProperties = "", int take = 0)
        {
            return LaptopRepo.Get(filter, orderBy, includeProperties, take);
        }

        public IEnumerable<Laptops> GetAll()
        {
            return LaptopRepo.Get(null, null, String.Empty, 0);
        }

        public Laptops GetById(int id)
        {
            return LaptopRepo.GetByID(id);
        }

        public void Update(Laptops laptop)
        {
            LaptopRepo.Update(laptop);
            Unit.Save();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Unit.Dispose();
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
