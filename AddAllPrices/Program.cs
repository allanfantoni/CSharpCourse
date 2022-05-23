using AddAllPrices.Entities;

List<Product> list = new()
{
    new Product("Tv", 900.00),
    new Product("Mouse", 50.00),
    new Product("Tablet", 350.50),
    new Product("HD Case", 80.90),
};

// Action<Product> act = UpdatePrice;
// Action<Product> act = p => { p.Price += p.Price * 0.1; };

// list.ForEach(act);
// list.ForEach(UpdatePrice);
list.ForEach(p => { p.Price += p.Price * 0.1; });

foreach (Product product in list)
{
    Console.WriteLine(product);
}

// static void UpdatePrice(Product p) => p.Price += p.Price * 0.1;