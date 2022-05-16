namespace CalculateGreaterValue.Entities
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string? ToString() => $"{Name}, {Price:F2}";

        public int CompareTo(object? obj)
        {
            if (obj is not Product)
                throw new ArgumentException("Comparing error: argument is not a product.");

            Product? other = obj as Product;

            return Price.CompareTo(other.Price);
        }
    }
}