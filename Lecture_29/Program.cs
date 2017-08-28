using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Lecture_29.Math;

namespace Lecture_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.Firstname = "John";
            john.Lastname = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
