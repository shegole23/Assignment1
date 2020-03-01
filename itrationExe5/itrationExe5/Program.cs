using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itrationExe5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter a series of numbers separated 
            //by comma. Find the maximum of the numbers and display it on the console. 
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter multiple numbers separaed by coma: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach(var str in numbers)
            {
                var number = int.Parse(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max number is: {0}",max);
            
        }
    }
}
