using System;

namespace Lecture_59
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = new TimeSpan(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Duration: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Minutes: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("ToString: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
