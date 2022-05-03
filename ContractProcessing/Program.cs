using ContractProcessing.Entities;
using ContractProcessing.Services;
using System.Globalization;

try
{
    Console.WriteLine("Enter contract data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Date (MM/dd/yyyy): ");
    DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
    Console.Write("Contract value: ");
    double totalValue = double.Parse(Console.ReadLine());
    Console.Write("Enter number of installments: ");
    int installments = int.Parse(Console.ReadLine());

    Contract contract = new(number, date, totalValue);

    ContractProcessingService contractProcessing = new(new PayPalPaymentService());
    contractProcessing.ProcessContract(contract, installments);

    Console.WriteLine("Installments:");

    foreach (Installment installment in contract.Installments)
    {
        Console.WriteLine(installment);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}