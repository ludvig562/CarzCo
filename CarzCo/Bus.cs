using System;

namespace CarzCo;

internal class Bus : Vehicle, IDriveable
{
    public Bus(string brand, string model, string year, string colour, int capacity, int maxSpeed, string gas) : base(brand, model, year, colour, capacity, maxSpeed, gas)
    {
    }

    public void Drive()
    {
    }
}
