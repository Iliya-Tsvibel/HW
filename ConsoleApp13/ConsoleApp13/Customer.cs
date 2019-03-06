using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Customer : IComparable<Customer>
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public string Address { get; set; }
        public int Protection { get; set; }
        public int TotalPurchases { get; set; }

        public Customer(int id, string name, int birthYear, string address, int protection, int totalPurchases)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
            Address = address;
            Protection = protection;
            TotalPurchases = totalPurchases;
        }

        public override string ToString()
        {
            return $"The ID {Id} ||| Name is {Name} ||| Data of birth day {BirthYear} ||| Address {Address} ||| Protection {Protection} ||| Total Purchases {TotalPurchases}";
        }

        public int CompareTo(Customer other)
        {
            return this.Protection - other.Protection;
        }


       

       
    }
    class PurchasesComparer : IComparer<Customer>
    {
        public int Compare(Customer a, Customer b)
        {
            return a.TotalPurchases - b.TotalPurchases;
        }
    }

    class BirthYearComparer : IComparer<Customer>
    {
        public int Compare(Customer a, Customer b)
        {
            return (b.BirthYear - a.BirthYear);
        }
    }
}
