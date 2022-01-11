namespace Exercicio1.Services
{
    interface IPaymentService
    {
        double CalculateInstallment(double baseValue, int number);
    }
}