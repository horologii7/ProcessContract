using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessContract.Entities
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            this.installments = new List<Installment>();
        }

        public void addInstallment(Installment installment)
        {
            installments.Add(installment);
        }
    }
}
