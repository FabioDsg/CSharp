using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2- Write a program which takes two numbers from the console and displays the maximum of the two. 

namespace Exercie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            var number1 = Console.ReadLine();
            Console.WriteLine("Enter another number");
            var number2 = Console.ReadLine();

            var result = Math.Max(int.Parse(number1), int.Parse(number2));

            Console.WriteLine("The greater of values is: " + result);
        }
    }
}
