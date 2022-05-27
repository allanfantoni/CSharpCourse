using EmployeeInfo.Entities;
using System.Globalization;

try
{
    Console.Write("Enter full file path: ");
    var path = Console.ReadLine();

    Console.Write("Enter salary: ");
    var baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    List<Employee> list = new();

    using var reader = File.OpenText(path);
    while (!reader.EndOfStream)
    {
        string[] fields = reader.ReadLine().Split(',');
        var name = fields[0];
        var email = fields[1];
        var salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
        list.Add(new(name, email, salary));
    }

    Console.WriteLine($"Email of people whose salary is more than {baseSalary:F2}:");

    var higherSalary = list.Where(x => x.Salary > baseSalary).OrderBy(x => x.Email).Select(x => x.Email);

    foreach (var item in higherSalary)
        Console.WriteLine(item);

    Console.Write("Sum of salary of people whose name starts with 'M': ");

    var sumOfSalary = list.Where(x => x.Name.StartsWith('M')).Sum(x => x.Salary);

    Console.WriteLine(sumOfSalary.ToString("F2", CultureInfo.InvariantCulture));
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}