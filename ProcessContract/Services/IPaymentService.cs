using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessContract.Services
{
    interface IPaymentService
    {
        double paymentFee(double amount);
        double interest(double amount, int months);
    }
}
