using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Catagory> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().HasData(
                new Catagory { Id = 1, Name="Action", DisplayOrder = 1},
                 new Catagory { Id = 2, Name = "Action", DisplayOrder = 2},
                  new Catagory { Id = 3, Name = "Action", DisplayOrder = 3}
                );

        }

    }
}
