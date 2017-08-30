using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1- Write a program and ask the user to enter a number. The number should be between 1 to 10. 
If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
*/

namespace Exercie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number between 1 and 10.");
            var number = Console.ReadLine();

            if (int.Parse(number) > 1 && int.Parse(number) < 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
