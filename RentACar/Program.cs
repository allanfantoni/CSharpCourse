using RentACar.Entities;
using RentACar.Services;
using System.Globalization;

try
{
    Console.WriteLine("Enter rental data");
    Console.Write("Car model: ");
    string model = Console.ReadLine();
    Console.Write("Pickup (MM/dd/yyyy hh:mm): ");
    DateTime start = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);
    Console.Write("Return (MM/dd/yyyy hh:mm): ");
    DateTime finish = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);

    Console.Write("Enter price per hour: ");
    double hour = double.Parse(Console.ReadLine());
    Console.Write("Enter price per day: ");
    double day = double.Parse(Console.ReadLine());

    CarRental carRental = new(start, finish, new Vehicle(model));

    RentalService rentalService = new(hour, day, new BrazilTaxService());
    rentalService.ProcessInvoice(carRental);

    Console.WriteLine("INVOICE:");
    Console.WriteLine(carRental.Invoice);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}