using System;

namespace consructoresStudy
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
