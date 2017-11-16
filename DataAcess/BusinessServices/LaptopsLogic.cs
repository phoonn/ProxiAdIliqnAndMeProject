using System.Collections.Generic;
using Interfaces;
using Models;
using Repositories;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace BusinessServices
{
    public class LaptopsLogic : ICrudLogic<Laptop>
    {
        private UnitOfWork unit;

        public UnitOfWork Unit
        {
            get { return this.unit ?? new UnitOfWork(); }
        }

        public void Create(Laptop laptop)
        {
            Unit.LaptopRepo.Insert(laptop);
        }

        public void Delete(Laptop laptop)
        {
            Unit.LaptopRepo.Delete(laptop);
        }

        public void DeleteById(int id)
        {
            Unit.LaptopRepo.Delete(id);
        }

        public IEnumerable<Laptop> GetAll(
            Expression<Func<Laptop, bool>> filter = null,
            Func<IQueryable<Laptop>, IOrderedQueryable<Laptop>> orderBy = null,
            string includeProperties = "", int take = 0)
        {
            return Unit.LaptopRepo.Get(filter, orderBy, includeProperties, take);
        }

        public IEnumerable<Laptop> GetAll()
        {
            return Unit.LaptopRepo.Get(null, null, String.Empty, 0);
        }

        public Laptop GetById(int id)
        {
            return Unit.LaptopRepo.GetByID(id);
        }

        public void Update(Laptop laptop)
        {
            Unit.LaptopRepo.Update(laptop);
        }
    }
}
