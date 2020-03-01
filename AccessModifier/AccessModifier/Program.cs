using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1982, 1, 1);
            Console.WriteLine(person.Age);
        }
    }
}

