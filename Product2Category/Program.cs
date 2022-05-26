﻿using Product2Category.Entities;

try
{
    Category c1 = new() { Id = 1, Name = "Tools", Tier = 2 };
    Category c2 = new() { Id = 2, Name = "Computers", Tier = 1 };
    Category c3 = new() { Id = 3, Name = "Electronics", Tier = 1 };

    List<Product> products = new()
    {
        new() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
        new() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
        new() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
        new() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
        new() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
        new() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
        new() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
        new() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
        new() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
        new() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
        new() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
    };

    var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
    Print("TIER 1 AND PRICE < 900:", r1);

    var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
    Print("NAMES OF PRODUCTS FROM TOOLS:", r2);

    var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
    Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

    var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
    Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);

    var r5 = r4.Skip(2).Take(4);
    Print("TIER 1 ORDER BY PRICE THEN BY NAME SKYP 2 TAKE 4:", r5);

    var r6 = products.FirstOrDefault();
    Console.WriteLine($"FIRST OR DEFAULT TEST 1: {r6}");
    PrintLines();

    var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
    Console.WriteLine($"FIRST OR DEFAULT TEST 2: {r7}");
    PrintLines();

    var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
    Console.WriteLine($"SINGLE OR DEFAULT TEST 1: {r8}");
    PrintLines();

    var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
    Console.WriteLine($"SINGLE OR DEFAULT TEST 2: {r9}");
    PrintLines();

    var r10 = products.Max(p => p.Price);
    Console.WriteLine($"MAX PRICE: {r10}");
    PrintLines();

    var r11 = products.Min(p => p.Price);
    Console.WriteLine($"MIN PRICE: {r11}");
    PrintLines();

    var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
    Console.WriteLine($"CATEGORY 1 SUM PRICES: {r12}");
    PrintLines();

    var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
    Console.WriteLine($"CATEGORY 1 AVERAGE PRICES: {r13}");
    PrintLines();

    var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
    Console.WriteLine($"CATEGORY 5 AVERAGE PRICES: {r14}");
    PrintLines();

    var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
    Console.WriteLine($"CATEGORY 1 AGGREGATE SUM: {r15}");
    PrintLines();

    var r16 = products.GroupBy(p => p.Category);

    foreach (var group in r16)
    {
        Console.WriteLine($"Category {group.Key.Name}:" );

        foreach (var product in group)
            Console.WriteLine(product);

        Console.WriteLine();
    }
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T item in collection)
        Console.WriteLine(item);

    Console.WriteLine();
    Console.WriteLine("=======");
    Console.WriteLine();
}

static void PrintLines()
{
    Console.WriteLine();
    Console.WriteLine("=======");
    Console.WriteLine();
}