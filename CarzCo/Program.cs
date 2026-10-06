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
            AddVehicle(vehicles);

            Console.WriteLine("Alla fordon:");
            foreach (var vehicle in vehicles)
            {
                PrintVehicleSpecs(vehicle);
            }

            // Console.WriteLine("\nBara bilar:");
        }

        static void PrintVehicleSpecs(Vehicle vehicle)
        {
            Console.WriteLine($"{vehicle.Brand} {vehicle.Model} {vehicle.Year} {vehicle.Colour}");
        }

        static void AddVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine("Vilken typ av fordon vill du lägga till? [1] Bil [2] Motorcykel [3] Lastbil");
            if (int.TryParse(Console.ReadLine(), out int userChoice))
            {
                Console.WriteLine("Vilken märke är fordonet?");
                string brand = Console.ReadLine();
                Console.WriteLine("Vad är modellen på fordonet?");
                string model = Console.ReadLine();
                Console.WriteLine("Vilket år är fordonet gjort i?");
                string year = Console.ReadLine();
                Console.WriteLine("Vilken färg har fordonet?");
                string colour = Console.ReadLine();

                switch (userChoice)
                {
                    case 1:
                        vehicles.Add(new Car(brand, model, year, colour));
                        break;
                    case 2:
                        vehicles.Add(new Motorcycle(brand, model, year, colour));
                        break;
                    case 3:
                        vehicles.Add(new Truck(brand, model, year, colour));
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
    }
}
