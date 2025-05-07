// IQuoteCalculator.cs
// Esta interfaz define los métodos necesarios para calcular el pago mensual de una cotización y validar las cotizaciones según las reglas de negocio.

namespace ProyectoCotizacion.Domain.Interfaces
{
    public interface IQuoteCalculator
    {
        // Método para calcular el pago mensual basado en los parámetros de la cotización.
        decimal CalculateMonthlyPayment(decimal price, decimal downPayment, int termInMonths, decimal residualValue, decimal interestRate);

        // Método para validar una cotización según las reglas de negocio definidas.
        bool ValidateQuote(decimal price, decimal downPayment, int termInMonths, decimal residualValue);
    }
}