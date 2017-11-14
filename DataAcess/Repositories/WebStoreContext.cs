using System.Data.Entity;
using Models;

namespace Repositories
{
    public class WebStoreContext : DbContext
    {
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<PC> PCs { get; set; }


        public WebStoreContext() : base("name=DbConnection")
        {
            this.Laptops = this.Set<Laptop>();
            this.PCs = this.Set<PC>();
        }
    }
}
