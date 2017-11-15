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
            unit.LaptopRepo.Insert(laptop);
        }

        public void Delete(Laptop laptop)
        {
            unit.LaptopRepo.Delete(laptop);
        }

        public void DeleteById(int id)
        {
            unit.LaptopRepo.Delete(id);
        }

        public List<Laptop> GetAll(
            Expression<Func<Laptop, bool>> filter = null,
            Func<IQueryable<Laptop>, IOrderedQueryable<Laptop>> orderBy = null,
            string includeProperties = "", int take = 0)
        {
            return unit.LaptopRepo.Get(filter, orderBy, includeProperties, take).ToList();
        }

        public Laptop GetById(int id)
        {
            return unit.LaptopRepo.GetByID(id);
        }

        public void Update(Laptop entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
