using System;

namespace ProyectoCotizacion.Domain.Services
{
    public class QuoteCalculator : IQuoteCalculator
    {
        // Método para calcular el pago mensual basado en la fórmula de pago de Excel
        public decimal CalculateMonthlyPayment(decimal price, decimal downPayment, int termInMonths, decimal residual, decimal interestRate)
        {
            // Validar que el residual no supere el 30% del precio
            if (residual > price * 0.30m)
            {
                throw new ArgumentException("El residual no debe superar el 30% del precio.");
            }

            // Calcular el monto financiado
            decimal financedAmount = price - downPayment - residual;

            // Calcular la tasa de interés mensual
            decimal monthlyInterestRate = interestRate / 100 / 12;

            // Calcular el pago mensual usando la fórmula de amortización
            decimal monthlyPayment = (financedAmount * monthlyInterestRate) / (1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), -termInMonths));

            return monthlyPayment;
        }

        // Método para validar las reglas de negocio para una cotización
        public void ValidateQuote(decimal price, decimal downPayment, int termInMonths, decimal residual)
        {
            // Validar el enganche mínimo según el plazo
            if (termInMonths == 12 && downPayment < price * 0.10m)
            {
                throw new ArgumentException("El enganche mínimo para un plazo de 12 meses es del 10% del precio.");
            }
            else if (termInMonths >= 12 && termInMonths <= 23 && downPayment < price * 0.075m)
            {
                throw new ArgumentException("El enganche mínimo para un plazo de 12 a 23 meses es del 7.5% del precio.");
            }
            else if (termInMonths > 24 && downPayment < price * 0.05m)
            {
                throw new ArgumentException("El enganche mínimo para un plazo mayor a 24 meses es del 5% del precio.");
            }
        }
    }
}