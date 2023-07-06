using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicitloading.Data
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Model> Modeller { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                            @"server=(localdb)\MSSQLLocalDB; database=ExlicitLoading;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Marka>().HasData(
                new Marka() { Id = 1, Ad = "Peugeot" },
                new Marka() { Id = 2, Ad = "Mercedes"},
                new Marka() { Id = 3, Ad = "Audi" },
                new Marka() { Id = 4, Ad = "Hyundai" }
               );

            modelBuilder.Entity<Model>().HasData(
               new Model { Id = 1, Ad = "206", MarkaId = 1 },
               new Model { Id = 2, Ad = "307", MarkaId = 1 },
               new Model { Id = 3, Ad = "407", MarkaId = 1 },
               new Model { Id = 4, Ad = "AMG One", MarkaId = 2 },
               new Model { Id = 5, Ad = "CLS", MarkaId = 2 },
               new Model { Id = 6, Ad = "EQC", MarkaId = 2 },
               new Model { Id = 7, Ad = "A1", MarkaId = 3 },
               new Model { Id = 8, Ad = "A3", MarkaId = 3 },
               new Model { Id = 9, Ad = "A4", MarkaId = 3 },
               new Model { Id = 10, Ad = "TT", MarkaId = 3 },
               new Model { Id = 11, Ad = "Accent Era", MarkaId = 4 },
               new Model { Id = 12, Ad = "i10", MarkaId = 4 },
               new Model { Id = 13, Ad = "i20", MarkaId = 4 },
               new Model { Id = 14, Ad = "i30", MarkaId = 4 }              
                );
        }
    }
}
