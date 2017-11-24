using Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Laptops 
    {
        [DataMember,Key]
        public int LaptopID { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string OS { get; set; }
        [Column(TypeName = "varbinary"),DataMember]
        public byte[] Image { get; set; }
        [DataMember]
        public int Ram { get; set; }
        [DataMember]
        public string Processor { get; set; }
        [DataMember]
        public string HardDisk { get; set; }
        [DataMember]
        public double Screen { get; set; }
        

    }
}
