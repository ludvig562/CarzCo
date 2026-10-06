using System;
using System.Collections.Generic;
using System.Text;

namespace CarzCo
{
    internal class Car : Vehicle, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Vroom vroom");
        }
    }
}
