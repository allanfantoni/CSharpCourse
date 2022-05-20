using ComparingCollections.Entities;

HashSet<Product> a = new();

a.Add(new Product("TV", 900.0));
a.Add(new Product("Notebook", 1200.0));

HashSet<Point> b = new();

b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

Product prod = new("Notebook", 1200.0);

Console.WriteLine(a.Contains(prod));

Point p = new(5, 10);
Console.WriteLine(b.Contains(p));