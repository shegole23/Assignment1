using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithTextExe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to count vowels");
            var input = Console.ReadLine().ToLower();
            if (string.IsNullOrWhiteSpace(input))
                Console.WriteLine("Invalid entry!");
            int count = 0;
            var vowles = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            foreach(var character in input)
            {
                if (vowles.Contains(character))
                    count++;
            }
            Console.WriteLine(count);

        }
    }
}
