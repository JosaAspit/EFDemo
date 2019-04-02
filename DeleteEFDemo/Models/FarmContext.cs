using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteEFDemo.Models
{
    public class FarmContext : DbContext
    {
        public FarmContext(DbContextOptions<FarmContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Worker> Workers { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Farm>().HasData(
                new Farm() { Id = -1, Name = "Hansen Bondegaard" },
                new Farm() { Id = -2, Name = "Klausens Kåde Kyllinger" }
            );
        }
    }
}
