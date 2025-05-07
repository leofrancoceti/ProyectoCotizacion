using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoCotizacion.Domain.Entities;
using ProyectoCotizacion.Infrastructure.Interfaces;

namespace ProyectoCotizacion.Infrastructure.Data
{
    // Implementación de un repositorio simulado para manejar cotizaciones en memoria.
    public class MockQuoteRepository : IQuoteRepository
    {
        private readonly List<Quote> _quotes;

        public MockQuoteRepository()
        {
            _quotes = new List<Quote>();
        }

        // Método para agregar una nueva cotización al repositorio.
        public void Add(Quote quote)
        {
            quote.Id = Guid.NewGuid(); // Asignar un nuevo Id a la cotización.
            _quotes.Add(quote);
        }

        // Método para obtener todas las cotizaciones.
        public IEnumerable<Quote> GetAll()
        {
            return _quotes;
        }

        // Método para obtener cotizaciones por cliente.
        public IEnumerable<Quote> GetByClientId(Guid clientId)
        {
            return _quotes.Where(q => q.ClientId == clientId);
        }
    }
}