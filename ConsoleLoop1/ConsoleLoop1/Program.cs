using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLoop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that display numbers tha can be devide  
            // by 3 from 1 to 100
            Console.WriteLine("This code will display prime numbers");
            
            for(int i = 1; i <= 100; i++)
            {
                if(i%3 ==0)
                {
                    Console.Write($"{i}");
                    Console.Write(", ");
                }
            }

        }
    }
}
