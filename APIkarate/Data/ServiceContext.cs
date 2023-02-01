using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<KarateProducts> KarateProducts { get; set; }
        //public DbSet<Orders> Orders { get; set; }
        //public DbSet<Brands> Brands { get; set; }
        //public DbSet<Users> Users { get; set; }
     
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<KarateProducts>()
            .ToTable("Products");

            //builder.Entity<Orders>()
            //.ToTable("Orders")
            //.HasOne<ProductItem>()
            //.WithMany();        

            //builder.Entity<Brands>()
            //.ToTable("Brands");

            //builder.Entity<Users>()
            //.ToTable("Users");

        }
    }
    public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
    {
        public ServiceContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("ServiceContext");
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

            return new ServiceContext(optionsBuilder.Options);
        }
    }
}
