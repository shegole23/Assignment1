using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        private const string TEXT_FILE_NAME = "Employee.txt";
        public string Name { get; set; }
        public string Title { get; set; }

        public static void WriteEmployee(Employee employee)
        {
            var employeeData = $"{employee.Name} , {employee.Title}";
            FileHelper.WriteTextFileAsync(TEXT_FILE_NAME, employeeData);
        }
        //public static ICollection<Employee> GetAllEmployees()
        //{
        //    return employeeData;
        //}
    }
}
