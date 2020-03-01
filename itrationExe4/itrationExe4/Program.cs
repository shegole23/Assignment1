using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itrationExe4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that picks a random number between 1 and 10.Give the user 4 chances 
            //to guess the number.If the user guesses the number, display “You won"; otherwise," +
            //" display “You lost". (To make sure the program is behaving correctly, you can display 
            //the secret number on the console first.)
            //int i = 0;
            
            for(int i = 0; i <= 4; i++)
            {
                var random = new Random();
                var randomNumber = random.Next(1, 10);
                Console.Write("Pick a random number from 1 to 10: ");
                int number = int.Parse(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("You won! u guessed the righ number!");
                    Console.WriteLine("your number {0} and computer number {1}", number, randomNumber);
                }
                else
                {
                    Console.WriteLine("You lost!");
                    Console.WriteLine("your number {0} and computer number {1}", number, randomNumber);
                }
                
            }
           
        }
    }
}
