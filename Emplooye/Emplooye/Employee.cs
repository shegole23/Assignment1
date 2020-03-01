using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Emplooye
{
    class DataStorage
    {
        public static void Store(Employee employee)
        {
            var stream = new FileStream(
                employee.FirstName + employee.LastName + ".dat",
                FileMode.Create);
            var writer = new StreamWriter(stream);
            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            writer.Dispose();
        }
        public static Employee Load(string firstName, string lastName)
        {
            var employee = new Employee();
            var stream = new FileStream(firstName +
                lastName + ".dat", FileMode.Open);
            var reader = new StreamReader(stream);
            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary = reader.ReadLine();

            reader.Dispose();
            return employee;
        }
    }
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Salary;
        public void Save()
        {
            DataStorage.Store(this);
        }

        public string GetName()
        {
            return $"{ FirstName } { LastName }";
        }
        public void SetName(string newFirstName, 
            string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
            Console.WriteLine(
                $"Name changed to '{this.GetName() }'");
            Console.ReadLine();
        }
    }
}
