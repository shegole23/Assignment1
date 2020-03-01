using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " "+ LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName +
                "- Part time employee");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName +
                "- Full time employee");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName +
                "- Temporary time employee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[4];
            employee[0] = new Employee();
            employee[1] = new PartTimeEmployee();
            employee[2] = new FullTimeEmployee();
            employee[3] = new TemporaryEmployee();

            foreach(Employee e in employee)
            {
                e.PrintFullName();
            }
        }
    }
}
