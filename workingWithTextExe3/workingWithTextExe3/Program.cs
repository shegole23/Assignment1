using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithTextExe3
{
    class Program25
    {
        static void Main(string[] args)
        {
            /*3 - Write a program and ask the user to enter a time value 
             * in the 24 - hour time format(e.g. 19:00). A valid time should
             * be between 00:00 and 23:59.If the time is valid, display 
             * "Ok"; otherwise, display "Invalid Time".If the user doesn't
             * provide any values, consider it as invalid time */

            Console.WriteLine("Enter a time in 24 hour format:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                Console.WriteLine("Invalid");
            var numbers = new List<int>();
            foreach (var number in input.Split(':'))
                numbers.Add(Convert.ToInt32(number));
            if((numbers[0] > 24 && numbers[0] < 0) || (numbers[1] > 59 || numbers[1] < 0))
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("OK");
            Console.ReadLine();

        }
    }
}
