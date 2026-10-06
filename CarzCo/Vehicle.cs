using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarzCo
{
    internal abstract class Vehicle
    {
        public string Brand { get; set; } = "Unknown";
        public string Model { get; set; } = "Unknown";
        public string Year { get; set; } = "Unknown";
        public string Colour { get; set; } = "Unknown";
        public int Capacity { get; set; } = 0;
        public int MaxSpeed { get; set; } = 0;
        public string Gas { get; set; } = "Unknown";

        public Vehicle(string brand, string model, string year, string colour, int capacity, int maxSpeed, string gas)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Colour = colour;
            Capacity = capacity;
            MaxSpeed = maxSpeed;
            Gas = gas;
        }
    }
}
