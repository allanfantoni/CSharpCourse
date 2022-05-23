using RemoveMinimumPrice.Entities;

List<Product> list = new()
{
    new Product("Tv", 900.00),
    new Product("Mouse", 50.00),
    new Product("Tablet", 350.50),
    new Product("HD Case", 80.90),
};

//list.RemoveAll(p => p.Price >= 100.0);
list.RemoveAll(ProductTest);

foreach (Product product in list)
    Console.WriteLine(product);

static bool ProductTest(Product p) => p.Price >= 100.0;