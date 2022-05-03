namespace ContractProcessing.Services
{
    public class PayPalPaymentService : IPaymentService
    {
        private const double MonthlyInterest = 0.01;
        private const double FeePercentage = 0.02;

        public double Interest(double amount, int month) => amount * MonthlyInterest * month;

        public double PaymentFee(double amount) => amount * FeePercentage;
    }
}