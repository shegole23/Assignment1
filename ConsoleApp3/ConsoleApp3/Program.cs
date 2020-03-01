using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadLine();
        }
    }
}
