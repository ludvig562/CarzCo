using System;

namespace CarzCo;

internal class Boat : Vehicle, IDriveable
{
    public Boat(string brand, string model, string year, string colour, int capacity, int maxSpeed, string gas) : base(brand, model, year, colour, capacity, maxSpeed, gas)
    {
    }

    public void Drive()
    {
        Console.WriteLine("TUTTTT!");
    }
}
