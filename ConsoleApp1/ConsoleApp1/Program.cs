using ConsoleApp.PostgreSQL;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Az Psql");

            PiotContext piotContext = new PiotContext();
            var cust = piotContext.Customers.ToArray();
            
        }
    }
}
