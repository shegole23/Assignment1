using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Pam",
                Salary = 6500
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };
            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            customers.Insert(0, customer3);
            foreach(Customer c in customers)
            {
                Console.WriteLine(c.ID);
            }
            customers.IndexOf(customer3, 0);
        }
    }
   public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    public class SavingCustomer : Customer
    {

    }
}
