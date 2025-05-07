// Este archivo define la interfaz IQuoteRepository, que declara métodos para acceder a los datos de cotizaciones.

using System.Collections.Generic;
using ProyectoCotizacion.Domain.Entities;

namespace ProyectoCotizacion.Infrastructure.Interfaces
{
    public interface IQuoteRepository
    {
        void AddQuote(Quote quote);
        IEnumerable<Quote> GetQuotesByClientId(int clientId);
    }
}