namespace ProyectoCotizacion.Domain.Entities
{
    // Clase que representa a un cliente en el sistema
    public class Client
    {
        // Identificador único del cliente
        public int Id { get; set; }

        // Nombre del cliente
        public string Nombre { get; set; }

        // Correo electrónico del cliente
        public string Email { get; set; }
    }
}