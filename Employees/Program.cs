﻿using Employees.Entities;

try
{
    List<Employee> list = new List<Employee>();

    Console.Write("Enter the number of employess: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Employee #{i} data:");
        Console.Write("Outsourced (y/n)? ");
        char ch = char.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine());

        if (ch == 'y' || ch == 'Y')
        {
            Console.Write("Additional charge: ");
            double additionalCharge = double.Parse(Console.ReadLine());
            list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
        }
        else
        {
            list.Add(new Employee(name, hours, valuePerHour));
        }
    }

    Console.WriteLine();
    Console.WriteLine("PAYMENTS:");

    foreach (Employee emp in list)
    {
        Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"));
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}