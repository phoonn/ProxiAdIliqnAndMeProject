using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingService.CrudService;

namespace TestingService
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudServiceOf_LaptopClient service = new CrudServiceOf_LaptopClient();
            Laptop[] laptops = service.GetAllLaptops();
            Console.WriteLine(laptops[0].Brand+" "+laptops[0].HardDisk);
            Console.ReadKey();
            service.Close();
        }
    }
}
