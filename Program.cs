using oop_lesson_4_parking.models;
using System;

namespace oop_lesson_4_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Parking Application *********");

            //Calling my class Driver.cs
            Driver driver = new Driver();

            driver.CreateClasses();
            driver.PopulateCarPark();
        }
    }
}
