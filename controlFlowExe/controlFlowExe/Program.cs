using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlFlowExe
{
    class Program
    {
        static void Main(string[] args)
           /* 1- Write a program and ask the user to enter a number.
            The number should be between 1 to 10. If the user enters a valid number, 
            display "Valid" on the console.Otherwise, display "Invalid".
            */
        {
            Console.Write("Enter a number between 1 to 10: ");
            int number = int.Parse(Console.ReadLine());
            if(number >= 1 && number <=10)
                Console.WriteLine("The number is valid!");
            else
                Console.WriteLine("The number is invalid");
        }
    }
}
