namespace ProyectoCotizacion.Application.DTOs
{
    
    /// Clase que representa un objeto de transferencia de datos (DTO) para una cotización.

    public class QuoteDto
    
        /// Obtiene o establece el precio de la cotización.
       
        public decimal Precio { get; set; }

        /// Obtiene o establece el enganche de la cotización.
     
        public decimal Enganche { get; set; }

    
        /// Obtiene o establece el plazo de la cotización en meses.
       
        public int Plazo { get; set; }

      
        /// Obtiene o establece el valor residual de la cotización.
    
        public decimal Residual { get; set; }

    
        /// Obtiene o establece la tasa de interés de la cotización.
    
        public decimal Tasa { get; set; }
    }
}