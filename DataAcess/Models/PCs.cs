using System.ComponentModel.DataAnnotations.Schema;
using Interfaces;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class PCs : IEntity
    {
        [Column("PCID"),DataMember]
        public int Id { get; set; }
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
