namespace ProyectoCotizacion.Application.Interfaces
{
    public interface IQuoteService
    {
        // Método para calcular el pago mensual de una cotización
        decimal CalculateMonthlyPayment(QuoteDto quoteDto);

        // Método para guardar una cotización
        void SaveQuote(QuoteDto quoteDto);

        // Método para obtener las cotizaciones por cliente
        IEnumerable<QuoteDto> GetQuotesByClient(int clientId);
    }
}