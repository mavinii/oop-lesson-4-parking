using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class Carpark
    {
        // Collection of the Car Park
        // It allows me to have a list of customers, the list is in Driver class
        public List<Customer> listOfCustomers = new List<Customer>();

        public Carpark()
        {
            Console.WriteLine("* This is the CarPark Class");
        }

        public override string ToString()
        {
            return "--------------------- CAR PARK TO STRING METHOD";
        }

        //Function to calculate charges
        public void CalculateCharges()
        {
            foreach (Customer currentCustomer in listOfCustomers)
            {
                Console.WriteLine("Calculating Charges");
            }
        }
    }
}
