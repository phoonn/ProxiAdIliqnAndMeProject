using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Models;
using Interfaces;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class LaptopCrudService : ICrudService<Laptop>
    {
        public bool CreateLaptop(Laptop laptop)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLaptop(Laptop laptop)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLaptopById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Laptop> GetAllLaptops()
        {
            throw new NotImplementedException();
        }

        public Laptop GetLaptopById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Laptop laptop)
        {
            throw new NotImplementedException();
        }
    }
}
