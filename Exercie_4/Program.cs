using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
    Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
    If the user enters a value less than the speed limit, program should display Ok on the console. 
    If the value is above the speed limit, the program should calculate the number of demerit points. 
    For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
    If the number of demerit points is above 12, the program should display License Suspended. 
     
*/

namespace Exercie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a speed limit. ");
            var speedLimit = Console.ReadLine();
            Console.WriteLine("Enter a speed of a car. ");
            var speedOfCar = Console.ReadLine();

            if (int.Parse(speedOfCar) < int.Parse(speedLimit))
            {
                Console.WriteLine("OK. ");
            }
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (int.Parse(speedOfCar) - int.Parse(speedLimit)) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }

        }
    }
}
