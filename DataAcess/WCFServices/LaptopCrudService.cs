using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Models;
using Interfaces;
using BusinessServices;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
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

        public void DeleteLaptop (Laptop laptop)
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
