using System.ComponentModel.DataAnnotations.Schema;
using Interfaces;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [DataContract]
    public class PCs
    {
        [DataMember,Key]
        public int PCID { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string OS { get; set; }
        [DataMember]
        public int Ram { get; set; }
        [DataMember]
        public string Processor { get; set; }
        [DataMember]
        public string HardDisk { get; set; }
        [DataMember]
        public string VideoCard { get; set; }
        [DataMember]
        public string Case { get; set; }
        [DataMember]
        public string PowerSupply { get; set; }
    }
}
