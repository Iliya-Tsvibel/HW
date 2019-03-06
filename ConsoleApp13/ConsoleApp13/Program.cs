using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
           
           
            {
                new Customer(1, "Iliya", 1979, "Rishon", 5, 4000),
                new Customer(2, "Igor", 1984, "Jerusalem", 35, 5000),
                new Customer(3, "Valery", 1950, "Jerusalem", 7, 3000),
                new Customer(4, "Tatyana", 1953, "Jerusalem", 3, 1000)
            };

            Console.WriteLine("==================== Customers list");
            customers.ForEach(a => Console.WriteLine(a)); // List of customers as is;

            Console.WriteLine("==================== Compared by protection"); // deafult comared by protection;
            customers.Sort();
            customers.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("==================== Compared by purchases");
            customers.Sort(new PurchasesComparer());
            customers.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("==================== Compared by birth day");
            customers.Sort(new BirthYearComparer());
            customers.ForEach(a => Console.WriteLine(a));

            MyQueue myQueue = new MyQueue();
            myQueue.Init(customers);
            Console.WriteLine($"Next customer in line=======================================:");
            Console.WriteLine(myQueue.WholsNext());



            
            Customer c = myQueue.DequeueProtectzia();
            Console.WriteLine($"This costumer has higher protection=======================================:");
            Console.WriteLine(c);

           
            
            









        }
    }
}

