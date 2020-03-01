using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 0;
            //int product = 0;
            //Calculate(10, 20, out total, out product);
            //Console.WriteLine("Sum is {0} && product is {1}",total,product);
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            Program.ParamsMethod(106,123,125,124);

        }
        public static void Calculate(int FN, int SN, out int sum, out int product)
        {
            sum = FN + SN;
            product = FN * SN;
        }
        public static void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements",numbers.Length);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
