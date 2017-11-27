using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    [DataContract]
    public class LaptopDTO
    {
        [DataMember]
        public int LaptopID { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string OS { get; set; }
        [ DataMember]
        public byte[] Image { get; set; }
        [DataMember]
        public int Ram { get; set; }
        [DataMember]
        public string Processor { get; set; }
        [DataMember]
        public string HardDisk { get; set; }
        [DataMember]
        public double Screen { get; set; }

        [DataMember]
        public virtual List<UsersLaptopsDTO> UsersLaptops {get; set; }
    }
}
