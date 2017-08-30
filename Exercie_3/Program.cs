using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    3- Write a program and ask the user to enter the width and height of an image.
    Then tell if the image is landscape or portrait.
*/

namespace Exercie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a width. ");
            var width = Console.ReadLine();
            Console.WriteLine("Enter a height. ");
            var height = Console.ReadLine();

            
            if(int.Parse(width) > int.Parse(height))
            {
                Console.WriteLine("It's a landscape. ");
            }
            else
            {
                Console.WriteLine("It's a portrait. ");
            }
        }
    }
}
