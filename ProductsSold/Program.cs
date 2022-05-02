using ProductsSold.Entities;

try
{
    Console.Write("Enter full path file: ");
    string sourceFilePath = Console.ReadLine();

    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    string targetFolderPath = sourceFolderPath + @"\Out";
    string targetFilePath = targetFolderPath + @"\Summary.csv";

    string[] lines = File.ReadAllLines(sourceFilePath);
    
    string[] fields = new string[3];
    
    string name = string.Empty;
    double price = 0;
    int quantity = 0;

    Directory.CreateDirectory(targetFolderPath);

    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        foreach (string line in lines)
        {
            fields = line.Split(',');
            name = fields[0];
            price = double.Parse(fields[1]);
            quantity = int.Parse(fields[2]);

            Product product = new Product(name, price, quantity);

            sw.WriteLine($"{product.Name},{product.Total().ToString("F2")}");
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}