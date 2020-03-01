using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new SavingAccount(50);
            var s2 = new SavingAccount(100);
            Console.WriteLine($"Interest rate is {SavingAccount.GetInterestRate()}");

            var s3 = new SavingAccount(10000.75);
            Console.WriteLine($"Interest rate is {SavingAccount.GetInterestRate()}");
        }
    }
}
