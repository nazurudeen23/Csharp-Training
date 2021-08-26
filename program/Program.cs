
using System;
using System.Collections.Generic;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "nazu",
                Salary=85000
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "nazur",
                Salary = 95000
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "nazuru",
                Salary = 75000
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Before sorting: ");
            foreach(Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }
            listCustomers.Sort();
            listCustomers.Reverse();
            Console.WriteLine("After sorting: ");
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine(c.Salary);
            }
        }

        public class Customer:IComparable<Customer>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary{ get; set; }

            public int CompareTo(Customer other)
            {
                return this.Salary.CompareTo(other.Salary);
            }
        }
    }
}
