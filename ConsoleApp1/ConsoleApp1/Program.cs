using ConsoleApp.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Az Psql");

            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var conStr = configuration.GetConnectionString("PiotDB");


            PiotContext piotContext = new PiotContext(new DbContextOptionsBuilder<PiotContext>()
                       .UseNpgsql(conStr)
                       .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                       .Options);

            piotContext.Customers.Add(new Customer() { CustomerID = 12, CustomerName = "Fiskeby" });
            piotContext.SaveChanges();
            
            var cust = piotContext.Customers.ToArray();
            
        }
    }
}
