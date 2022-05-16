using CalculateGreaterValue.Entities;
using CalculateGreaterValue.Services;

try
{
    List<Product> list = new();

    Console.Write("Enter N: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        string[] vect = Console.ReadLine().Split(',');
        string name = vect[0];
        double price = double.Parse(vect[1]);
        list.Add(new Product(name, price));
    }

    CalculationService calculationService = new();

    Product max = calculationService.Max(list);

    Console.WriteLine("Max:");
    Console.WriteLine(max);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}