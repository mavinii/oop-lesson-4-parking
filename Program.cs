using oop_lesson_4_parking.models;
using System;

namespace oop_lesson_4_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Parking Application *********");
            Console.WriteLine("");

            // It is calling Driver.cs class
            Driver driver = new Driver();

            driver.CreateClasses();
            driver.PopulateCarPark();

        }
    }
}
