using Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Laptop : IEntity
    {
        [Column("LaptopID")]
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public string OS { get; set; }
        [Column(TypeName = "varbinary")]
        public byte[] Image { get; set; }

        public int Ram { get; set; }

        public string Processor { get; set; }

        public string HardDisk { get; set; }

        public double Screen { get; set; }

    }
}
