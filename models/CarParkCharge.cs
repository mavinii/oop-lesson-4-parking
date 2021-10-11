using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class CarparkCharge
    {
        // Constructor method
        public CarparkCharge()
        {
            Console.WriteLine("* This is the Car Park Charge Class");
        }

        public override string ToString()
        {
            return "--------------------- CAR PARK CHARGE TO STRING METHOD";
        }

        // Function to minimum Fee = 2
        public int CalculateCharges(int hoursParked)
        {
            int minimumFee = 2;

            return minimumFee * 2;
        }
    }
}
