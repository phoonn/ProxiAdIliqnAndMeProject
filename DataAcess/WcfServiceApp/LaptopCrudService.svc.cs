using BusinessServices;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LaptopCrudService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LaptopCrudService.svc or LaptopCrudService.svc.cs at the Solution Explorer and start debugging.
    public class LaptopCrudService : ICrudService<Laptop>
    {
        private LaptopsLogic laptoplogic;

        public LaptopsLogic LaptopLogic
        {
            get { return this.laptoplogic ?? new LaptopsLogic(); }
        }
        public List<Laptop> GetAllLaptops()
        {
            return LaptopLogic.GetAll();
        }

        public Laptop GetLaptopById(int id)
        {
            return LaptopLogic.GetById(id);
        }

        public void DeleteLaptop(Laptop laptop)
        {
            LaptopLogic.Delete(laptop);
        }

        public void DeleteLaptopById(int id)
        {
            LaptopLogic.DeleteById(id);
        }

        public void CreateLaptop(Laptop laptop)
        {
            LaptopLogic.Create(laptop);
        }

        public void Update(Laptop laptop)
        {
            LaptopLogic.Update(laptop);
        }
    }
}
