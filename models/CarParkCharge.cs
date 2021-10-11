using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class CarparkCharge
    {
        //Properties for the minimum fee and minimum Hours
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }


        // Constructor method with 2 in parameters by default
        public CarparkCharge(int _minimumFee = 2, int _minimumHours = 3)
        {
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
            Console.WriteLine("* This is the Car Park Charge Class");
        }


        public override string ToString()
        {
            return "--------------------- CAR PARK CHARGE TO STRING METHOD";
        }


        // Method or Function for calculating Charges
        public int CalculateCharges(int hoursParked)
        {
            return minimumFee * minimumFee;
        }
    }
}
