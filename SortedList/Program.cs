using SortedList.Entities;

try
{
    List<Product> list = new();

    list.Add(new Product("TV", 900.00));
    list.Add(new Product("Notebook", 1200.00));
    list.Add(new Product("Tablet", 450.00));

    list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

    foreach (Product p in list)
    {
        Console.WriteLine(p);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}