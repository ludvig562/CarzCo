using System.Reflection.PortableExecutable;

namespace CarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list
            List<Vehicle> vehicles = new List<Vehicle>();

            //adding new vehicles
            vehicles.Add(new Car("Volvo", "V60", "1999", "grå"));
            vehicles.Add(new Motorcycle("Honda", "VTX", "2009", "blå"));
            vehicles.Add(new Truck("Scania", "Super 560", "2010", "gul"));

            Console.WriteLine("Alla fordon:");
            foreach(var vehicle in vehicles)
            {
                PrintVehicleSpecs(vehicle);
            }

            Console.WriteLine("\nBara bilar:");
            
        }

        static void PrintVehicleSpecs(Vehicle vehicle)
        {
            Console.WriteLine($"{vehicle.Brand} {vehicle.Model} {vehicle.Year} {vehicle.Colour}");
        }

        static void GetInfo()
        {
            Console.WriteLine("Vilken typ av fordon vill du lägga till? [1] Car [2] Motorcyle [3] Truck");
            if (int.TryParse(Console.ReadLine(), out int userChoice))
            {
                switch (userChoice)
                {
                    case 1:

                        break;

                    case 2:
                        break;

                    case 3:
                        break;
                    default:
                        Console.WriteLine("Du måste välja 1, 2 eller 3!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Du måste skriva en siffra!");
            }


        }
        static void AddVehicle()
        {
           
        }

    }
}
