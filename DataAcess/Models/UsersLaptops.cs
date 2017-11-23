using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class UsersLaptops : IEntity
    {
        [Column("UserLaptopID")]
        public int Id { get; set; }
        
        public int LaptopID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        public virtual Laptops Laptops { get; set; }
    }
}
