using ProductPriceAverage.Entities;
using System.Globalization;

try
{
    Console.Write("Enter file full path: ");
    var path = Console.ReadLine();

    List<Product> list = new();

    using var reader = File.OpenText(path);
    while (!reader.EndOfStream)
    {
        string[] fields = reader.ReadLine().Split(',');
        var name = fields[0];
        var price = double.Parse(fields[1], CultureInfo.InvariantCulture);
        list.Add(new(name, price));
    }

    var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
    Console.WriteLine($"Average price: {avg:F2}");

    var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

    foreach (var item in names)
    {
        Console.WriteLine(item);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}