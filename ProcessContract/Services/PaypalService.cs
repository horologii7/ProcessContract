using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessContract.Services
{
    class PaypalService : IPaymentService
    {
        private const double _monthlyInterest = 0.01;
        private const double _feePercentage = 0.02;

        public double interest(double amount, int months)
        {
            return amount * _monthlyInterest * months;
        }

        public double paymentFee(double amount)
        {
            return amount * _feePercentage;
        }
    }
}
