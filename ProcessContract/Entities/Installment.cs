using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessContract.Entities
{
    class Installment
    {
        public DateTime dueDate { get; private set; }
        public double amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }
    }
}
