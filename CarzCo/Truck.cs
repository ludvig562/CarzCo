using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    internal class Truck : Vehicle, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Toot toot, VRRRRRRRROOM");
        }
    }
}
