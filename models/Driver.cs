using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class Driver will pushing all our code
// It is very important
namespace oop_lesson_4_parking.models
{
    public class Driver
    {
        // CTOR = creates a constructor for us
        // CW   = creates a console write line
        public Driver()
        {
            Console.WriteLine("This is the Driver Class");
        }

        public void CreateClasses()
        {
            Carpark carpark = new Carpark();
            Console.WriteLine(carpark.ToString());

            Customer customer = new Customer();
            Console.WriteLine(customer.ToString());

            CarParkCharge carparkcharge = new CarParkCharge();
            Console.WriteLine(carparkcharge.ToString());
        }

        // Method created to populate the Car Park
        public void PopulateCarPark()
        {
            Console.WriteLine("Populating the Car Park");
            Carpark carpark = new Carpark();

            // Customer list
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();
            Customer c4 = new Customer();
            Customer c5 = new Customer();

            // Adding customers in the list in the CarPark Class
            // List must be PUBLIC
            carpark.listOfCustomers.Add(c1);
            carpark.listOfCustomers.Add(c2);
            carpark.listOfCustomers.Add(c3);
            carpark.listOfCustomers.Add(c4);
            carpark.listOfCustomers.Add(c5);

            // Calling the function to calculate the charges
            carpark.CalculateCharges();
        }
    }
}
