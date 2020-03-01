using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSizeExe2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter the width and height of an image.
             Then tell if the image is landscape or portrait.
             */

            Console.WriteLine("This code determine type of image.");
            Console.Write("Enter height of the image: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter width of the image: ");
            int width = int.Parse(Console.ReadLine());

            if(height > width)
                Console.WriteLine("The image is portrait!");
            else
                Console.WriteLine("The image is landscape!");

        }
    }
}
