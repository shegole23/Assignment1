using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodstudy1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.EvenNumbers();
            Program.EvenNumbers(10);
            Program p = new Program();
           int sum = p.Add(10, 20);
           Console.WriteLine("Sum is {0}", sum);
          
        }
        public int Add(int FN, int SN )
        {
            return FN + SN;
        }
        public static void EvenNumbers(int target)
        {
            int start = 0;
            while(start <= target)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
