using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlFlowExe1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which takes two numbers from 
            //the console and displays the maximum of the two.

            Console.WriteLine("This code will identify the maxumum out of two numbers.");
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
                Console.WriteLine("The first number {0} is the max", number1);
            else
                Console.WriteLine("The second number {0} is the max", number2);

        }
    }
}
