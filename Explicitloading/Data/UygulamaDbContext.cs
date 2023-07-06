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
    }
}
