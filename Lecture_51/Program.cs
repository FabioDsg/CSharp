﻿using System;

namespace Lecture_51
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 3, 7, 9, 2, 14, 6};

            //length
            Console.WriteLine("Lenth: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of clear(): ");
            foreach(var n in numbers)
                Console.WriteLine(n);
            
            //Copy()
            int [] another = new int[3];
            Array.Copy(numbers, another, 3);
            
            Console.WriteLine("Effect of Copy(): ");
                foreach(var n in another)
                Console.WriteLine(n);

            //Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort(): ");
                foreach(var n in numbers)
                Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse(): ");
                foreach(var n in numbers)
                Console.WriteLine(n);



        }
    }
}
