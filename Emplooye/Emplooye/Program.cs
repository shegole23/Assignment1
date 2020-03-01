using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplooye
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            var employee2 = new Employee();
            var employee = new Employee();
            employee2.SetName("Inigo", "Montoya");
            employee2.Save();

            employee1.FirstName = "Inigo";
            employee1.LastName = "Montoya";
            employee1.Salary = "Too Little";
            IncreaseSalary(employee1);
            employee1 = DataStorage.Load("Inigo", "Montoya");
            Console.WriteLine(
                $"{employee1.GetName() }: { employee1.Salary}");
                
        }
        public static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }
}
