using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    internal class Motorcycle : Vehicle, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Vrrrrrrrrooom");
        }
    }
}
