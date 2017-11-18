using System.Data.Entity;
using Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Repositories
{
    public class WebStoreContext : IdentityDbContext<User>
    {
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<PC> PCs { get; set; }

        

        public WebStoreContext() : base("name=DbConnection")
        {
            this.Laptops = this.Set<Laptop>();
            this.PCs = this.Set<PC>();

            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
