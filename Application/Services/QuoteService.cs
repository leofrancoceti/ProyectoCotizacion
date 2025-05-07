using System.Collections.Generic;
using System.Linq;
using ProyectoCotizacion.Domain.Entities;
using ProyectoCotizacion.Application.DTOs;
using ProyectoCotizacion.Application.Interfaces;
using ProyectoCotizacion.Infrastructure.Interfaces;

namespace ProyectoCotizacion.Application.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly IQuoteRepository _quoteRepository;
        private readonly IClientRepository _clientRepository;

        public QuoteService(IQuoteRepository quoteRepository, IClientRepository clientRepository)
        {
            _quoteRepository = quoteRepository;
            _clientRepository = clientRepository;
        }

        public void SaveQuote(QuoteDto quoteDto)
        {
            // Convertir QuoteDto a Quote y guardar en el repositorio
            var quote = new Quote
            {
                ClienteId = quoteDto.ClienteId,
                Precio = quoteDto.Precio,
                Enganche = quoteDto.Enganche,
                Plazo = quoteDto.Plazo,
                Residual = quoteDto.Residual,
                Tasa = quoteDto.Tasa
            };

            _quoteRepository.Add(quote);
        }

        public IEnumerable<QuoteDto> GetQuotesByClient(int clientId)
        {
            // Obtener cotizaciones por cliente y convertir a QuoteDto
            var quotes = _quoteRepository.GetByClientId(clientId);
            return quotes.Select(q => new QuoteDto
            {
                Precio = q.Precio,
                Enganche = q.Enganche,
                Plazo = q.Plazo,
                Residual = q.Residual,
                Tasa = q.Tasa
            });
        }

        public decimal CalculateMonthlyPayment(QuoteDto quoteDto)
        {
            // Lógica para calcular el pago mensual usando formulas (Depende de doonde, en lo personal fue de Excel)
            decimal monthlyRate = quoteDto.Tasa / 100 / 12;
            int totalPayments = quoteDto.Plazo;
            decimal loanAmount = quoteDto.Precio - quoteDto.Enganche;

            decimal monthlyPayment = (loanAmount * monthlyRate) / (1 - (decimal)Math.Pow((double)(1 + monthlyRate), -totalPayments));
            return monthlyPayment;
        }
    }
}