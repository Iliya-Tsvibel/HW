using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class MyQueue
    {
        private List<Customer> customers = new List<Customer>();
        public void Sort()
        {
            this.customers.Sort();
        }

        public void Enqueue(Customer cust)
        {
            this.customers.Add(cust);
        }

        public Customer Dequeue()

        {
            if (customers.Count > 0)
            {
                Customer result = customers[0];
                customers.RemoveAt(0);
                return result;
            }
            return null;


        }

       
       
       

        public void Init(List<Customer> newList)
        {
            this.customers = newList;
        }

        public void Clear()
        {
            customers.Clear();
        }

        public Customer WholsNext()
        {
            return customers[0];
        }

        public int Count
        {
            get
            {
                return this.customers.Count;
            }
        }

        public void SortByProtection()
        {

            this.customers.Sort();
        }

        public void SortByTotalPurchases()
        {
            customers.Sort(new PurchasesComparer());
        }

        public void SortByBirthYear()
        {
            this.customers.Sort(new BirthYearComparer());
        }

        public List<Customer> DequeueCustomers(int reduseCustomersNumber)
        {
            for (int i = 0; i < reduseCustomersNumber; i++)
            {
                customers.RemoveAt(0);
            }
            return customers;
        }

        public void AniRakSheela(Customer customer)
        {
            List<Customer> Huzpa = new List<Customer>();
            Huzpa.Add(customer);
            for (int i = 0; i < customers.Count(); i++)
            {
                Huzpa.Add(customers[i]);
            }
            customers = Huzpa;
        }

        public Customer DequeueProtectzia()
        {
            int maxProtectionIndex = 0;
            int protectzia = 0;
            for (int i = 0; i < this.customers.Count; i++)
            {
                if (this.customers[i].Protection > maxProtectionIndex)
                {
                    maxProtectionIndex = this.customers[i].Protection;
                    protectzia = i;
                }
            }
            Customer x = this.customers[protectzia];
            this.customers.RemoveAt(protectzia);
            return x;
        }
        
    }

  
}
