using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itrationExe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console
            var sum = 0;
            while(true)
            {
                Console.WriteLine("Enter a number: ");
                var input = Console.ReadLine();
                if (input == "ok")
                    break;
                else
                {
                    var number = int.Parse(input);
                    sum += number;
                }
               
            }
            Console.WriteLine("Sum of entered number is: {0}",sum);
        }
    }
}
