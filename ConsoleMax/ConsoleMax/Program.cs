using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which takes two numbers 
            //from the console and displays the maximum of the two.
            Console.WriteLine("This console app display the max number " +
                "out of two numbers");
            Console.Write("Enter the first number: ");
            int inputNum1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int inputNum2 = int.Parse(Console.ReadLine());

            if(inputNum1 > inputNum2)
            {
                Console.WriteLine($"The max number is {inputNum1}");
            }
            else
            {
                Console.WriteLine($"The max number is {inputNum2}");
            }
        }
    }
}
