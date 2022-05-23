using UpperCaseForName.Entities;

List<Product> list = new()
{
    new Product("Tv", 900.00),
    new Product("Mouse", 50.00),
    new Product("Tablet", 350.50),
    new Product("HD Case", 80.90),
};

// List<string> result = list.Select(NameUpper).ToList();

// Func<Product, string> func = NameUpper;
// Func<Product, string> func = p => p.Name.ToUpper();
// List<string> result = list.Select(func).ToList();
List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

foreach (string product in result)
{
    Console.WriteLine(product);
}

// static string NameUpper(Product p) => p.Name.ToUpper();