using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    internal class Car : Vehicle, IDriveable
    {
        public Car(string brand, string model, string year, string colour, int capacity, int maxSpeed, string gas) : base(brand, model, year, colour, capacity, maxSpeed, gas)
        {
        }

        public void Drive()
        {
            Console.WriteLine("Vroom vroom");
        }
    }
}
