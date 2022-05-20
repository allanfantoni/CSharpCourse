try
{
    Dictionary<string, int> map = new();

    Console.Write("Enter file full path: ");
    string path = Console.ReadLine();

    using StreamReader sr = File.OpenText(path);

    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(',');
        string name = line[0];
        int count = int.Parse(line[1]);

        if (map.ContainsKey(name))
            map[name] += count;
        else
            map.Add(name, count);
    }

    foreach (var item in map)
        Console.WriteLine($"{item.Key}: {item.Value}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}