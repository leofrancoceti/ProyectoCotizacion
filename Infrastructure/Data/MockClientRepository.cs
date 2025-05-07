using System.Collections.Generic;
using System.Linq;
using ProyectoCotizacion.Domain.Entities;
using ProyectoCotizacion.Infrastructure.Interfaces;

namespace ProyectoCotizacion.Infrastructure.Data
{
    // Implementación de un repositorio simulado para manejar datos de clientes en memoria.
    public class MockClientRepository : IClientRepository
    {
        private readonly List<Client> _clients;

        public MockClientRepository()
        {
            // Inicializa la lista de clientes con algunos datos de ejemplo(Ejemplos de clientes).
            // En un entorno real, esto podría ser una base de datos() pero sin base por ahora.
            // Aquí se inicializan los clientes de ejemplo.
            _clients = new List<Client>
            {
                new Client { Id = 1, Nombre = "Leonardo Franco", Email = "leofraco300@gmail.com" },
                new Client { Id = 2, Nombre = "RAÚL Franco", Email = "raulfranco15@gmail.com" }
            };
        }

        // Método para obtener todos los clientes.
        public IEnumerable<Client> GetAll()
        {
            return _clients;
        }

        // Método para obtener un cliente por su ID.
        public Client GetById(int id)
        {
            return _clients.FirstOrDefault(c => c.Id == id);
        }

        // Método para agregar un nuevo cliente.
        public void Add(Client client)
        {
            client.Id = _clients.Max(c => c.Id) + 1; // Asigna un nuevo ID.
            _clients.Add(client);
        }

        // Método para actualizar un cliente existente.
        public void Update(Client client)
        {
            var existingClient = GetById(client.Id);
            if (existingClient != null)
            {
                existingClient.Nombre = client.Nombre;
                existingClient.Email = client.Email;
            }
        }

        // Método para eliminar un cliente por su ID.
        public void Delete(int id)
        {
            var client = GetById(id);
            if (client != null)
            {
                _clients.Remove(client);
            }
        }
    }
}