namespace Bank.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double withdrawLimit, double loanLimit) : base(number, holder, balance, withdrawLimit)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double value)
        {
            if (value <= LoanLimit)
                Balance += value;
        }
    }
}