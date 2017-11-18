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
        private UnitOfWork Unit;
        
        public void Create(Laptop laptop)
        {
            using (Unit = new UnitOfWork())
            {
                Unit.LaptopRepo.Insert(laptop);
                Unit.Save();
            }
        }

        public void Delete(Laptop laptop)
        {
            using (Unit = new UnitOfWork())
            {
                Unit.LaptopRepo.Delete(laptop);
                Unit.Save();
            }
        }

        public void DeleteById(int id)
        {
            using (Unit = new UnitOfWork())
            {
                Unit.LaptopRepo.Delete(id);
                Unit.Save();
            }
        }
        
        public IEnumerable<Laptop> GetAll(
            Expression<Func<Laptop, bool>> filter = null,
            Func<IQueryable<Laptop>, IOrderedQueryable<Laptop>> orderBy = null,
            string includeProperties = "", int take = 0)
        {
            using (Unit = new UnitOfWork())
            {
                return Unit.LaptopRepo.Get(filter, orderBy, includeProperties, take);
            }
        }

        public IEnumerable<Laptop> GetAll()
        {
            using (Unit = new UnitOfWork())
            {
                return Unit.LaptopRepo.Get(null, null, String.Empty, 0);
            }
        }

        public Laptop GetById(int id)
        {
            using (Unit = new UnitOfWork())
            {
                return Unit.LaptopRepo.GetByID(id);
            }
        }

        public void Update(Laptop laptop)
        {
            using (Unit = new UnitOfWork())
            {
                Unit.LaptopRepo.Update(laptop);
                Unit.Save();
            }
        }
        
    }
}
