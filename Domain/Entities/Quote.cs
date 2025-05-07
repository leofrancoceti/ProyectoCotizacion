namespace ProyectoCotizacion.Domain.Entities
{
    public class Quote
    {
        public int Id { get; set; } // Identificador único de la cotización
        public int ClientId { get; set; } // Identificador del cliente asociado a la cotización(El Id del cliente)
        public decimal Precio { get; set; } // Precio total del bien a arrendar
        public decimal Enganche { get; set; } // Monto del enganche inicial
        public int Plazo { get; set; } // Plazo del arrendamiento en meses
        public decimal Residual { get; set; } // Valor residual al final del arrendamiento  
        public decimal Tasa { get; set; } // Tasa de interés aplicada a la cotización

        // Constructor por defecto
        public Quote() { }

        // Constructor con parámetros
        public Quote(int id, int clientId, decimal precio, decimal enganche, int plazo, decimal residual, decimal tasa)
        {
            Id = id;
            ClientId = clientId;
            Precio = precio;
            Enganche = enganche;
            Plazo = plazo;
            Residual = residual;
            Tasa = tasa;
        }
    }
}