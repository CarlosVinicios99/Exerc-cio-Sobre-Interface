using System;
using System.Globalization;
using Exercicio1.Entities;
using Exercicio1.Services;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract Data: ");

            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Data (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            Console.Write("Enter number of installments: ");
            int installmentsQuantity = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService(), installmentsQuantity);

            contractService.ProcessContract(contract);

            Console.WriteLine();
            Console.WriteLine("INSTALLMENTS: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
