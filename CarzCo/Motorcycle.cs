using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    internal class Motorcycle : Vehicle, IDriveable
    {
        public Motorcycle(string brand, string model, string year, string colour) : base(brand, model, year, colour)
        {
        }

        public void Drive()
        {
            Console.WriteLine("Vrrrrrrrrooom");
        }
    }
}
