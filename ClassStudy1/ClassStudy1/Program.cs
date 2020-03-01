using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Customer
{
    string _firstName;
    string _lastName;

    public Customer() : 
        this("No FirstName Provided, ",
        "No LastName Provided")
    {

    }
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0} {1}", this._firstName, this._lastName);
    }
    ~Customer()
    {
        //Clean up code
    }
}

namespace ClassStudy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.PrintFullName();
            Customer c2 = new Customer("P", "A");
            c2.PrintFullName();
        }
    }
}
