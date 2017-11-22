using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStore.Models
{
    public class CreateLaptopModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string OS { get; set; }
        public int Ram { get; set; }
        public string Processor { get; set; }
        public string HardDisk { get; set; }
        public double Screen { get; set; }
    }
}