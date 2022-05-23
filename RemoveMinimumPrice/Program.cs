using RemoveMinimumPrice.Entities;

namespace RemoveMinimumPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTest);

            foreach (Product product in list)
                Console.WriteLine(product);
        }

        public static bool ProductTest(Product p) => p.Price >= 100.0;
    }
}