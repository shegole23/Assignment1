using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithTextExe4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4- Write a program and ask the user to enter a few words
             * separated by a space. Use the words to create a variable
             * name with PascalCase. For example, if the user types: 
             * "number of students", display "NumberOfStudents".
             * Make sure that the program is not dependent on the 
             * input. So, if the user types "NUMBER OF STUDENTS", 
             * the program should still display "NumberOfStudents".*/

            Console.WriteLine("Enter few words separated by space");
            var input = Console.ReadLine();
            var inputs = input.Trim().ToLower();
            var words = new List<string>();
            foreach (var word in inputs.Split(' '))
            {
                var newWord = char.ToUpper(word[0]) + word.Substring(1);
                words.Add(newWord);
            }
            for(var i = 0; i < words.Count; i++)
            {
                var variableName = String.Join("", words[i]);
                Console.Write(value: variableName);
                
            }
            Console.WriteLine();
        }
    }
}
