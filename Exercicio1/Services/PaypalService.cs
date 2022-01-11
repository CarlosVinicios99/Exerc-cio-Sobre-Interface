namespace Exercicio1.Services
{
    class PaypalService : IPaymentService
    {
        public double CalculateInstallment(double baseValue, int number)
        {
            double amountInstallment = baseValue;
            amountInstallment += baseValue * 0.01 * number;

            amountInstallment += amountInstallment * 0.02;

            return amountInstallment;
        }
    }
}