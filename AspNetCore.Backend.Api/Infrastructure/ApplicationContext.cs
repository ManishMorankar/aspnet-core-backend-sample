using AspNetCore.Backend.Api.Data;
using AspNetCore.Backend.Api.DbModels;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Backend.Api.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(SeedData.GetProducts());

            base.OnModelCreating(modelBuilder);
        }
    }
}