using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract(IsReference =true)]
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


        [IgnoreDataMember]
        public virtual ICollection<UsersLaptops> UsersLaptops { get; set; }

        //public Laptops()
        //{
        //    UsersLaptops = new Collection<UsersLaptops>();
        //}

        //public IEnumerable<UsersLaptops> GetUserLaptops()
        //{
        //    return UsersLaptops.Skip(0);
        //}

        //public void AddUserLaptop(UsersLaptops userlaptops)
        //{
        //    UsersLaptops.Add(userlaptops);
        //}

        //public static Expression<Func<Laptops, ICollection<UsersLaptops>>> ChildrenAccessor = f => f.UsersLaptops;

    }
}
