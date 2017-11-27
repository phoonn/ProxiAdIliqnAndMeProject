using Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    [DataContract]
    public class UsersLaptopsDTO
    {
        [DataMember]
        public int UserLaptopID { get; set; }

        [DataMember]
        public int LaptopID { get; set; }

        [DataMember]
        public string UserID { get; set; }

        [IgnoreDataMember]
        public virtual AspNetUsers AspNetUsers { get; set; }
        [IgnoreDataMember]
        public virtual Laptops Laptops { get; set; }
    }
}
