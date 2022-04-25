using Bank.Entities.Exceptions;

namespace Bank.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public virtual void Withdraw(double value)
        {
            if (value > WithdrawLimit)
            {
                throw new DomainException("the amount exceeds withdraw limit.");
            }
            if (value > Balance)
            {
                throw new DomainException("not enough balance.");
            }

            Balance -= value + 5.0;
        }
    }
}