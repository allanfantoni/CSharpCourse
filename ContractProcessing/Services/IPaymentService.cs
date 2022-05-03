namespace ContractProcessing.Services
{
    public interface IPaymentService
    {
        public double Interest(double amount, int month);

        public double PaymentFee(double amount);
    }
}