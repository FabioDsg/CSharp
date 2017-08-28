using System;

namespace Lecture_29
{
    public class Person
    {
        public string Firstname;
        public string Lastname;

        public void Introduce()
        {
            Console.WriteLine("My name is " + Firstname + " " + Lastname);
        }
    }
}
