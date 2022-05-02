string sourcePath = @"D:\Projects\Udemy\Programação orientada a objetos - C#\CSharpCourse\CSharpCourse\Files\Temp\file1.txt";
string targetPath = @"D:\Projects\Udemy\Programação orientada a objetos - C#\CSharpCourse\CSharpCourse\Files\Temp\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    Console.WriteLine($"File copied successfully to {targetPath}");
    Console.WriteLine();

    string[] lines = File.ReadAllLines(sourcePath);
    Console.WriteLine("The content of the file copied is:");

    foreach (string line in lines)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(line);
    }

    Console.ForegroundColor = ConsoleColor.Gray;
}
catch (IOException ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}