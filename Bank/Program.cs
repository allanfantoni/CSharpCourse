using Bank.Entities;

Account acc = new Account(1001, "Alex", 0.0);
BusinessAccount bAcc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

// upcasting

Account acc1 = bAcc;
Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

// downcasting

BusinessAccount acc4 = acc2 as BusinessAccount;
acc4.Loan(100.0);

if (acc3 is BusinessAccount)
{
    BusinessAccount acc5 = acc3 as BusinessAccount;
    acc5.Loan(200.0);
    Console.WriteLine("Loaned!");
}
else if (acc3 is SavingsAccount)
{
    SavingsAccount acc5 = acc3 as SavingsAccount;
    acc5.UpdateBalance();
    Console.WriteLine("Updated!");
}