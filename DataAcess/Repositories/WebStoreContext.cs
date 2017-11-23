using System.Data.Entity;
using Models;
using Models.Identity;

namespace Repositories
{
    public class WebStoreContext : DbContext
    {
        public DbSet<Laptops> Laptops { get; set; }
        public DbSet<PCs> PCs { get; set; }
        public DbSet<UsersLaptops> UsersLaptops { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

        public WebStoreContext() : base("name=DbConnection")
        {
            this.Laptops = this.Set<Laptops>();
            this.PCs = this.Set<PCs>();
            this.UsersLaptops = this.Set<UsersLaptops>();
            this.AspNetUsers = this.Set<AspNetUsers>();
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.UsersLaptops)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Laptops>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PCs>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);
        }
    }
}
