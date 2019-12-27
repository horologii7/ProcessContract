using System;
using System.Globalization;
using ProcessContract.Entities;
using ProcessContract.Services;

namespace ProcessContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(number, date, totalValue);
            Console.Write("Enter number of installments: ");
            int numberInstallments = Int32.Parse(Console.ReadLine());
            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract, numberInstallments);
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
