using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-2UJ5CTE; Database = RentACarDatabase; Trusted_Connection = true");
        }

        DbSet<Car> Cars { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Color> Colors { get; set; }
    }
}
