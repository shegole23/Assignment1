using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3,7,9,2,14,6 };
            //length
            Console.WriteLine("Length: " + numbers.Length);
            //Indexof()
            var Index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index Of 9: " + Index);
            //Clear()

            Array.Clear(numbers, 0, 2);
            foreach(var n in numbers)
            {
                Console.WriteLine(n);

            }

            //Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Conpy()");
            foreach(var n in another)
                Console.WriteLine(n);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort():");
            foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach(var n in numbers)
                Console.WriteLine(n);

        }
    }
}
