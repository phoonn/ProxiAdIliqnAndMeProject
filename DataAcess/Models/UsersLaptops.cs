﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Identity;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace Models
{
    [DataContract]
    public class UsersLaptops 
    {
        [DataMember,Key]
        public int UserLaptopID { get; set; }
        
        [DataMember]
        public int LaptopID { get; set; }

        [DataMember]
        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual Laptops Laptops { get; set; }
    }
}
