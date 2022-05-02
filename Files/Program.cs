string sourcePath = @"D:\Projects\Udemy\Programação orientada a objetos - C#\CSharpCourse\CSharpCourse\Files\Temp\file1.txt";
string targetPath = @"D:\Projects\Udemy\Programação orientada a objetos - C#\CSharpCourse\CSharpCourse\Files\Temp\file2.txt";

#region First steps handling files with File and FileInfo classes

//try
//{
//    FileInfo fileInfo = new FileInfo(sourcePath);
//    fileInfo.CopyTo(targetPath);
//    Console.WriteLine($"File copied successfully to {targetPath}");
//    Console.WriteLine();

//    string[] lines = File.ReadAllLines(sourcePath);
//    Console.WriteLine("The content of the file copied is:");

//    foreach (string line in lines)
//    {
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine(line);
//    }

//    Console.ForegroundColor = ConsoleColor.Gray;
//}
//catch (IOException ex)
//{
//    Console.WriteLine("An error occurred: " + ex.Message);
//}

#endregion

#region FileStream and StreamReader

//FileStream fs = null;
//StreamReader sr = null;

//try
//{
//    fs = new FileStream(sourcePath, FileMode.Open);
//    sr = new StreamReader(fs);
//    string line = sr.ReadLine();
//    Console.WriteLine(line);
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}
//finally
//{
//    if (fs != null)
//        fs.Close();

//    if (sr != null)
//        sr.Close();
//}

#endregion

#region Another example of using StreamReader without FileStream

//StreamReader sr = null;

//try
//{
//    sr = File.OpenText(sourcePath);

//    while (!sr.EndOfStream)
//    {
//        string line = sr.ReadLine();
//        Console.WriteLine(line);
//    }
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}
//finally
//{
//    if (sr != null)
//        sr.Close();
//}

#endregion

#region Using block

//try
//{
//    using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
//    {
//        using (StreamReader sr = new StreamReader(fs))
//        {
//            while (!sr.EndOfStream)
//            {
//                string line = sr.ReadLine();
//                Console.WriteLine(line);
//            }
//        }
//    }
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}

#endregion

#region Using block simplified

try
{
    using (StreamReader sr = File.OpenText(sourcePath))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

#endregion