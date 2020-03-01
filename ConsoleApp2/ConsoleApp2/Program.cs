using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName+ " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }
    public class PartTimeEmloyee : Employee
    {
        public float HourlySalary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Anwar";
            FTE.LastName = "Ali";
            FTE.YearlySalary = 500000; 
            FTE.PrintFullName();

            PartTimeEmloyee PTE = new PartTimeEmloyee();
            PTE.FirstName = "Adem";
            PTE.LastName = "Kedem";
            PTE.PrintFullName();
            PTE.HourlySalary = 175000;
        }
    }
}
