using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.PostgreSQL
{
    public class PiotContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseNpgsql("Server=piottestpg.postgres.database.azure.com;Database=piot;Port=5432;User Id=michellblomberg68@piottestpg;Password=hogge30%Gunvor;Ssl Mode=Require;");
        }
    }

    public class Customer
    {
        public long CustomerID { get; set; }
        public string CustomerName { get; set; }
    }

  
}
