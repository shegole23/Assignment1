using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlFlowExe3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* this code will accept speed limit from user. 
             then take a speed of a car to check violation */

            Console.Write("Enter speed limit for a road: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.Write("Enter speed of a car: ");
            int carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
                Console.WriteLine("OK!");
            else
            {
                int speedDiference = carSpeed - speedLimit;
                int dementPoint = speedDiference / 5;
                Console.WriteLine("dement point is {0}",dementPoint);
                if(dementPoint > 12)
                    Console.WriteLine("License Suspended.");
            }

        }
    }
}
