using RentACar.Entities;
using System.Globalization;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (MM/dd/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);
Console.Write("Return (MM/dd/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));