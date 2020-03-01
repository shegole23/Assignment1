using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //checking if a number is prime number
            int count = 0;
            Console.Write("Enter a number greater than 2 to check if its prime: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                Console.WriteLine($"T{num} is not a prime number!" +
                    $"number");
            }
            else
            {
                Console.WriteLine($"{num} is prime a number!");
            }
        }
    }
}
