using ContractProcessing.Entities;

namespace ContractProcessing.Services
{
    public class ContractProcessingService
    {
        private IPaymentService _paymentService;

        public ContractProcessingService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double quotaWithInterest = basicQuota + _paymentService.Interest(basicQuota, i);
                double totalQuota = quotaWithInterest + _paymentService.PaymentFee(quotaWithInterest);
                contract.AddInstallment(new Installment(date, totalQuota));
            }
        }
    }
}