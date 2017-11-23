using System.Collections.Generic;
using Interfaces;
using Models;
using Repositories;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace BusinessServices
{
    public class LaptopsLogic : ICrudLogic<Laptops> , IDisposable
    {
        private IUnitOfWork Unit;

        private bool disposed = false;

        public LaptopsLogic(IUnitOfWork unit)
        {
            Unit = unit;
        }
        
        public void Create(Laptops laptop)
        {
            Unit.Repository<Laptops>().Insert(laptop);
            Unit.Save();
        }

        public void Delete(Laptops laptop)
        {
            Unit.Repository<Laptops>().Delete(laptop);
            Unit.Save();
        }

        public void DeleteById(int id)
        {
            Unit.Repository<Laptops>().Delete(id);
            Unit.Save();
        }

        public IEnumerable<Laptops> GetAll(
            Expression<Func<Laptops, bool>> filter = null,
            Func<IQueryable<Laptops>, IOrderedQueryable<Laptops>> orderBy = null,
            string includeProperties = "", int take = 0)
        {
            return Unit.Repository<Laptops>().Get(filter, orderBy, includeProperties, take);
        }

        public IEnumerable<Laptops> GetAll()
        {
            return Unit.Repository<Laptops>().Get(null, null, String.Empty, 0);
        }

        public Laptops GetById(int id)
        {
            return Unit.Repository<Laptops>().GetByID(id);
        }

        public void Update(Laptops laptop)
        {
            Unit.Repository<Laptops>().Update(laptop);
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
