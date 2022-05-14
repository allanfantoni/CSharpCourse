using PrintValues;

try
{
    PrintService<int> printService = new();

    Console.Write("How many values? ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++)
    {
        int x = int.Parse(Console.ReadLine());
        printService.AddValue(x);
    }

    printService.Print();

    Console.WriteLine($"First: {printService.First()}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}