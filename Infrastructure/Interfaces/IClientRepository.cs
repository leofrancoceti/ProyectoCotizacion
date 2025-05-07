// IClientRepository.cs
// Esta interfaz define los métodos para acceder a los datos de clientes.

using System.Collections.Generic;
using ProyectoCotizacion.Domain.Entities;

namespace ProyectoCotizacion.Infrastructure.Interfaces
{
    public interface IClientRepository
    {
        // Método para obtener todos los clientes.
        IEnumerable<Client> GetAllClients();

        // Método para obtener un cliente por su ID.
        Client GetClientById(int id);

        // Método para agregar un nuevo cliente.
        void AddClient(Client client);
    }
}