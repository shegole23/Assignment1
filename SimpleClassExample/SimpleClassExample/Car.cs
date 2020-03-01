using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
   
    class Car
    {
        public string petName;
        public int currSpeed;

        public void PrintState()
            => Console.WriteLine($"{petName} is going {currSpeed} MPH.");
        public void SpeedUp(int delta)
            => currSpeed += delta;
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
    }
}
