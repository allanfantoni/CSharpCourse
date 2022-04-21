using TaxPayment.Entities;

try
{
    List<TaxPayer> list = new List<TaxPayer>();
    double totalTaxes = 0;

    Console.Write("Enter the number of tax payers: ");
    int n = int.Parse(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Tax payer #{i} data:");
        Console.Write("Individual or company (i/c)? ");
        char type = char.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual income: ");
        double anualIncome = double.Parse(Console.ReadLine());

        if (type == 'i' || type == 'I')
        {
            Console.Write("Health expenditures: ");
            double healthExpenditures = double.Parse(Console.ReadLine());
            list.Add(new Individual(name, anualIncome, healthExpenditures));
        }
        else 
        {
            Console.Write("Number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            list.Add(new Company(name, anualIncome, numberOfEmployees));
        }
    }

    Console.WriteLine();
    Console.WriteLine("TAXES PAID:");

    foreach (TaxPayer payer in list)
    {
        Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2"));
        totalTaxes += payer.Tax();
    }

    Console.WriteLine();
    Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2"));
}
catch (Exception ex)
{ 
    Console.WriteLine(ex.Message);
}