using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class Customer
    {
        // Two Properties, carRegistration and HoursParked
        public string carRegistration { get; set; }
        public int hoursParked { get; set; }


        // Iniciation those two properties with constructor
        public Customer(string _carRegistration, int _hoursParked)
        {
            carRegistration = _carRegistration;
            hoursParked = _hoursParked;
            Console.WriteLine("* This is the Customer Class");
        }

        // Basic override toString
        public override string ToString()
        {
            return $"--------------------- CUSTOMER TO STRING METHOD {carRegistration} : {hoursParked} ";
        }
    }
}
