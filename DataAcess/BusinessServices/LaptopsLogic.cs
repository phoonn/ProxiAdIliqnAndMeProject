using System.Collections.Generic;
using Interfaces;
using Models;
using Repositories;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace BusinessServices
{
    public class LaptopsLogic : ICrudLogic<Laptop> , IDisposable
    {
        private IUnitOfWork Unit;

        private bool disposed = false;

        //private UnitOfWork Unit
        //{
        //    get { return this.unit ?? ( unit = new UnitOfWork()); }
        //}

        public LaptopsLogic(IUnitOfWork unit)
        {
            Unit = unit;
        }
        
        public void Create(Laptop laptop)
        {
            Unit.Repository<Laptop>().Insert(laptop);
            Unit.Save();
        }

        public void Delete(Laptop laptop)
        {
            Unit.Repository<Laptop>().Delete(laptop);
            Unit.Save();
        }

        public void DeleteById(int id)
        {
            Unit.Repository<Laptop>().Delete(id);
            Unit.Save();
        }

        public IEnumerable<Laptop> GetAll(
            Expression<Func<Laptop, bool>> filter = null,
            Func<IQueryable<Laptop>, IOrderedQueryable<Laptop>> orderBy = null,
            string includeProperties = "", int take = 0)
        {
            return Unit.Repository<Laptop>().Get(filter, orderBy, includeProperties, take);
        }

        public IEnumerable<Laptop> GetAll()
        {
            return Unit.Repository<Laptop>().Get(null, null, String.Empty, 0);
        }

        public Laptop GetById(int id)
        {
            return Unit.Repository<Laptop>().GetByID(id);
        }

        public void Update(Laptop laptop)
        {
            Unit.Repository<Laptop>().Update(laptop);
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
