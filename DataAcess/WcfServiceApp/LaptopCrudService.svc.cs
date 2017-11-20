using BusinessServices;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LaptopCrudService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LaptopCrudService.svc or LaptopCrudService.svc.cs at the Solution Explorer and start debugging.
    public class LaptopCrudService : ICrudService<Laptop>
    {
        private LaptopsLogic laptoplogic;

        public LaptopsLogic LaptopLogic
        {
            get { return this.laptoplogic ?? (laptoplogic = new LaptopsLogic()); }
        }
        public IEnumerable<Laptop> GetAllLaptops()
        {
            return LaptopLogic.GetAll();
        }

        public Laptop GetLaptopById(int id)
        {
            return LaptopLogic.GetById(id);
        }

        public bool DeleteLaptop(Laptop laptop)
        {
            try
            {
                LaptopLogic.Delete(laptop);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLaptopById(int id)
        {
            try
            {
                LaptopLogic.DeleteById(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateLaptop(Laptop laptop)
        {
            try
            {
                LaptopLogic.Create(laptop);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Laptop laptop)
        {
            try
            {
                LaptopLogic.Update(laptop);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
