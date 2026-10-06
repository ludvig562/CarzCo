using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarzCo
{
    internal abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Colour { get; set; }

        public Vehicle(string brand, string model, string year, string colour)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Colour = colour;
        }
    }
}
