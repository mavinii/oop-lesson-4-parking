using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class Customer
    {
        // Car Registration is an unique adentifier
        public string carRegistration { get; set; }

        // Numbers of Hrs parked
        public int hoursParked { get; set; }

        // Constructor method
        public Customer(string _carRegistration, int _hoursParked)
        {
            carRegistration = _carRegistration;
            hoursParked = _hoursParked;
            Console.WriteLine("* This is the Customer Class");
        }

        public override string ToString()
        {
            return $"--------------------- CUSTOMER TO STRING METHOD {carRegistration} : {hoursParked} ";
        }
    }
}
