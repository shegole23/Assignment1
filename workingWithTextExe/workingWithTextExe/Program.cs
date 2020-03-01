using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace workingWithTextExe
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1- Write a program and ask the user to enter a few numbers
             * separated by a hyphen. Work out if the numbers are 
             * consecutive. For example, if the input is "5-6-7-8-9" 
             * or "20-19-18-17-16", display a message: "Consecutive";
             * otherwise, display "Not Consecutive".*/

            Console.WriteLine("Enter numbers separated by hyphen: ");

            var input = Console.ReadLine();
            var number = input.Split('-');
            var numbers = new List<int>();

            foreach (var num in numbers)
                numbers.Add(Convert.ToInt32(num));
            numbers.Sort();

            var isConsecutive = true;
            for(var i = 1; i < numbers.Count; i++)
            {
                if(numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            var message = isConsecutive ? "Conseecutive" : "Not Consecutive";
            
            Console.WriteLine(message);
        }
    }
}
