using System;

namespace ProyectoCotizacion.Application.Validators
{
    // Clase que valida las cotizaciones según las reglas de negocio definidas.
    public class QuoteValidator
    {
        // Método que valida una cotización.
        public bool Validate(QuoteDto quote)
        {
            // Verifica que el residual no supere el 30% del precio.
            if (quote.Residual > quote.Precio * 0.3)
            {
                return false; // La cotización es inválida.
            }

            // Verifica el enganche mínimo según el plazo.
            if (quote.Plazo == 12 && quote.Enganche < quote.Precio * 0.1)
            {
                return false; // La cotización es inválida.
            }
            else if (quote.Plazo >= 12 && quote.Plazo <= 23 && quote.Enganche < quote.Precio * 0.075)
            {
                return false; // La cotización es inválida.
            }
            else if (quote.Plazo > 24 && quote.Enganche < quote.Precio * 0.05)
            {
                return false; // La cotización es inválida.
            }

            return true; // La cotización es válida.
        }
    }
}