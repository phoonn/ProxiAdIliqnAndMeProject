using System.ComponentModel.DataAnnotations.Schema;
using Interfaces;

namespace Models
{
    public class PC : IEntity
    {
        [Column("PCID")]
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string OS { get; set; }

        public int Ram { get; set; }

        public string Processor { get; set; }

        public string HardDisk { get; set; }

        public string VideoCard { get; set; }

        public string Case { get; set; }

        public string PowerSupply { get; set; }
    }
}
