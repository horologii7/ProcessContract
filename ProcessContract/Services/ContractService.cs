using System;
using ProcessContract.Entities;

namespace ProcessContract.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService (IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void processContract (Contract contract, int months)
        {
            double basicQuota = contract.totalValue / months;
            for (int m = 1; m <= months; m++)
            {
                DateTime date = contract.date.AddMonths(m);
                double updatedQuota = basicQuota + _paymentService.interest(basicQuota, m);
                double fullQuota = updatedQuota + _paymentService.paymentFee(updatedQuota);
                contract.addInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
