using Bank.Entities;
using Bank.Entities.Exceptions;

#region Creating instances for Upcasting and Downcasting examples

//Account acc = new Account(1001, "Alex", 0.0);
//BusinessAccount bAcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

#endregion

#region Upcasting example

//Account acc1 = bAcc;
//Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
//Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

#endregion

#region Downcasting example

//BusinessAccount acc4 = acc2 as BusinessAccount;
//acc4.Loan(100.0);

//if (acc3 is BusinessAccount)
//{
//    BusinessAccount acc5 = acc3 as BusinessAccount;
//    acc5.Loan(200.0);
//    Console.WriteLine("Loaned!");
//}
//else if (acc3 is SavingsAccount)
//{
//    SavingsAccount acc5 = acc3 as SavingsAccount;
//    acc5.UpdateBalance();
//    Console.WriteLine("Updated!");
//}

#endregion

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account account = new Account(number, holder, initialBalance, withdrawLimit);

    Console.WriteLine();
    Console.WriteLine("Enter amount for withdraw: ");
    double withdrawValue = double.Parse(Console.ReadLine());
    account.Withdraw(withdrawValue);
    Console.WriteLine("New balance: " + account.Balance.ToString("F2"));
}
catch (FormatException ex)
{
    Console.WriteLine("Error in format: " + ex.Message);
}
catch (DomainException ex)
{
    Console.WriteLine("Withdraw error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}