using System;

namespace ConsoleExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var Informationtechnology = new Uprogram();
            Informationtechnology.Name = "Computer Science";
            Informationtechnology.Id = 123456;
            Console.WriteLine($"Program {Informationtechnology.Name} coure code is {Informationtechnology.Id}");
        }
    }
}
