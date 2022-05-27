Console.Write("Enter full file1 path: ");
var sourcePath = Console.ReadLine();

Console.Write("Enter full file2 path: ");
var targetPath = Console.ReadLine();

Console.Write("Enter full MyFolder path: ");
var path = Console.ReadLine();

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

//try
//{
//    using (StreamReader sr = File.OpenText(sourcePath))
//    {
//        while (!sr.EndOfStream)
//        {
//            string line = sr.ReadLine();
//            Console.WriteLine(line);
//        }
//    }
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}

#endregion

#region StreamWriter

//try
//{
//    string[] lines = File.ReadAllLines(sourcePath);

//    using (StreamWriter sw = File.AppendText(targetPath))
//    {
//        foreach (string line in lines)
//        {
//            sw.WriteLine(line.ToUpper());
//        }
//    }

//    Console.WriteLine("Successfully read first file and written second file.");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}

#endregion

#region Directory and DirectoryInfo

//try
//{
//    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
//    Console.WriteLine("Folders:");

//    foreach (string folderItem in folders)
//        Console.WriteLine(folderItem);

//    Console.WriteLine();

//    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
//    Console.WriteLine("Files:");

//    foreach (string fileItem in files)
//        Console.WriteLine(fileItem);

//    Directory.CreateDirectory(path + @"\newfolder");

//    Console.WriteLine();
//    Console.WriteLine("New folder created successfully.");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred: {ex.Message}");
//}

#endregion

#region Path

try
{
    Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
    Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
    Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(sourcePath)}");
    Console.WriteLine($"GetFileName: {Path.GetFileName(sourcePath)}");
    Console.WriteLine($"GetExtension: {Path.GetExtension(sourcePath)}");
    Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(sourcePath)}");
    Console.WriteLine($"GetFullPath: {Path.GetFullPath(sourcePath)}");
    Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

#endregion