using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenceType
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            
            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("Autumn beautiful!");
                    break;
                case Season.Summer:
                    Console.WriteLine("Perfect for hiking!");
                    break;
                default:
                    Console.WriteLine("IDK this season!");
                    break;

            }
        }
    }
}
