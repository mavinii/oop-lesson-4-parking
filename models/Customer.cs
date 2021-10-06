using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
    public class Customer
    {
        public Customer()
        {
            Console.WriteLine("* This is the Customer Class");
        }

        public override string ToString()
        {
            return "--------------------- CUSTOMER TO STRING METHOD";
        }
    }
}
