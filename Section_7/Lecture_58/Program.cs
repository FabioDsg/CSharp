using System;


namespace Lecture_58
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2017, 9, 9);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Hour: " + now.Hour);
           //Console.WriteLine("Hour: " + now.Minute);

           var tomorrow = now.AddDays(1);
           var yesterday = now.AddDays(-1);

           Console.WriteLine(now.ToString("yyyy-MM-dd"));

        }
    }
}
