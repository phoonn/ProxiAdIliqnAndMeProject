using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Models;
using System.ServiceModel.Description;
using Testing.LaptopService;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudServiceOf_LaptopClient service = new CrudServiceOf_LaptopClient();
            Laptop laptop = service.GetLaptopById(2);
            Console.WriteLine(laptop.Brand);
            Console.ReadKey();
            service.Close();
        }
    }
}
