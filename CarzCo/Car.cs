using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    internal class Car : Vehicle, IDriveable
    {
        public Car(string brand, string model, string year, string colour) : base(brand, model, year, colour)
        {
        }

        public void Drive()
        {
            Console.WriteLine("Vroom vroom");
        }
    }
}
