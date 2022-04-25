namespace Bank.Entities
{
    public sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double withdrawLimit, double interestRate) : base(number, holder, balance, withdrawLimit)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double value)
        {
            Balance -= value;
        }
    }
}