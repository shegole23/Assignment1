using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number.
            //The number should be between 1 to 10. If the user enters 
            // a valid number, display "Valid" on the console. 
            // Otherwise, display "Invalid". (This logic is used a lot in

            Console.Write("Enter a number between 1 to 10: ");
            int inputNum = int.Parse(Console.ReadLine());
                if (inputNum >= 1 && inputNum <= 10)
                {
                    Console.WriteLine("The number you entered is valid!!");
                }
                else
                {
                    Console.WriteLine("The number you entered is inValid");
     
                }

        }
    }
}
