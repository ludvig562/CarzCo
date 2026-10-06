using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    internal class Truck : Vehicle, IDriveable
    {
        public Truck(string brand, string model, string year, string colour, int capacity, int maxSpeed, string gas) : base(brand, model, year, colour, capacity, maxSpeed, gas)
        {
        }

        public void Drive()
        {
            Console.WriteLine("Toot toot, VRRRRRRRROOM");
        }
    }
}
