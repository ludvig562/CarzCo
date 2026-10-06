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
            vehicles.Add(new Car("Volvo", "V60", "1999", "grå", 5, 200, "diesel"));
            vehicles.Add(new Motorcycle("Honda", "VTX", "2009", "blå", 2, 300, "diesel"));
            vehicles.Add(new Truck("Scania", "Super 560", "2010", "gul", 3, 120, "diesel"));

            Console.WriteLine("Meny: \n[1] Lägg till ett fordon. \n[2] Ta bort ett fordon. \n[3] Visa alla fordon. \n[4] Filtrera fordon. \n[0] Exit");


            while (!int.TryParse(Console.ReadLine(), out int menuChoice))
            {
                switch (menuChoice)
                {
                    case 1:
                        AddVehicle(vehicles);
                        break;
                    case 2:
                        RemoveVehicle(vehicles);
                        break;
                    case 3:
                        Console.WriteLine("Alla fordon:");
                        foreach (var vehicle in vehicles)
                        {
                            PrintVehicleSpecs(vehicle);
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nBara bilar:");
                        var cars = FilterVehicles<Car>(vehicles);
                        foreach (var car in cars)
                        {
                            PrintVehicleSpecs(car);
                        }
                        break;
                    case 0:
                        break;

                }
            }
        }

        static void PrintVehicleSpecs(Vehicle vehicle)
        {
            Console.WriteLine($"{vehicle.Brand} {vehicle.Model} {vehicle.Year} {vehicle.Colour}");
        }

        static void AddVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine("Vilken typ av fordon vill du lägga till? \n[1] Bil \n[2] Motorcykel \n[3] Lastbil \n[4] Båt \n[5] Buss}");
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
                Console.WriteLine("Hur många personer får plats i fordonet?");
                int.TryParse(Console.ReadLine(), out int capacity);
                Console.WriteLine("Vad är max hastigheten?");
                int.TryParse(Console.ReadLine(), out int maxSpeed);
                Console.WriteLine("Vilken bränsletyp?");
                string gas = Console.ReadLine();



                switch (userChoice)
                {
                    case 1:
                        vehicles.Add(new Car(brand, model, year, colour, capacity, maxSpeed, gas));
                        break;
                    case 2:
                        vehicles.Add(new Motorcycle(brand, model, year, colour, capacity, maxSpeed, gas));
                        break;
                    case 3:
                        vehicles.Add(new Truck(brand, model, year, colour, capacity, maxSpeed, gas));
                        break;
                    case 4:
                        vehicles.Add(new Boat(brand, model, year, colour, capacity, maxSpeed, gas));
                        break;
                    case 5:
                        vehicles.Add(new Bus(brand, model, year, colour, capacity, maxSpeed, gas));
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

        static void RemoveVehicle(List<Vehicle> vehicles)
        {
            Console.WriteLine("Vilket fordon vill du ta bort? (Skriv märket)");
            string brand = Console.ReadLine();
            Console.WriteLine("Skriv model:");
            string model = Console.ReadLine();

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (model == vehicles[i].Model && brand == vehicles[i].Brand)
                {
                    vehicles.Remove(vehicles[i]);
                }
            }
        }

        static List<T> FilterVehicles<T>(List<Vehicle> vehicles) where T : Vehicle
        {
            return vehicles.OfType<T>().ToList();
        }
    }
}
