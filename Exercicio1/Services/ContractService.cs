using System;
using Exercicio1.Entities;

namespace Exercicio1.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;
        public int NumberOfInstallments {get; set;} 

        public ContractService(IPaymentService paymentService, int numberOfInstallments)
        {
            NumberOfInstallments = numberOfInstallments;
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract)
        {
            double baseValue = contract.TotalValue / NumberOfInstallments;
            for(int i = 1; i <= NumberOfInstallments; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double amount = _paymentService.CalculateInstallment(baseValue, i);
                contract.Installments.Add(new Installment(dueDate, amount));
            }
        }
    }
}