using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_37
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
                       
    }

        //Using static to simple calling without a object 
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
               
    }
}
