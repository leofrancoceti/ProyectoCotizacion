# Proyecto Cotización

Este proyecto es una solución en C# que implementa una arquitectura de tipo Onion (Clean Architecture) para calcular cotizaciones de arrendamiento. El enfoque principal es la claridad del diseño, la separación de responsabilidades y la mantenibilidad del código.

## Estructura del Proyecto

La solución está organizada en varias capas:

- **Domain (Core)**: Contiene las entidades del dominio y las reglas de negocio.
  - `Entities/Client.cs`: Define la clase `Client` que representa a un cliente.
  - `Entities/Quote.cs`: Define la clase `Quote` que representa una cotización de arrendamiento.
  - `Interfaces/IQuoteCalculator.cs`: Declara métodos para calcular y validar cotizaciones.
  - `Services/QuoteCalculator.cs`: Implementa la lógica de negocio para calcular cotizaciones.

- **Application**: Contiene la lógica de aplicación y la validación.
  - `DTOs/ClientDto.cs`: Define el DTO para el cliente.
  - `DTOs/QuoteDto.cs`: Define el DTO para la cotización.
  - `Services/QuoteService.cs`: Maneja la lógica de aplicación para guardar y obtener cotizaciones.
  - `Validators/QuoteValidator.cs`: Valida las cotizaciones según las reglas de negocio.
  - `Interfaces/IQuoteService.cs`: Declara métodos para calcular y guardar cotizaciones.

- **Infrastructure**: Contiene implementaciones de repositorios simulados.
  - `Data/MockClientRepository.cs`: Repositorio simulado para manejar datos de clientes.
  - `Data/MockQuoteRepository.cs`: Repositorio simulado para manejar datos de cotizaciones.
  - `Interfaces/IClientRepository.cs`: Declara métodos para acceder a los datos de clientes.
  - `Interfaces/IQuoteRepository.cs`: Declara métodos para acceder a los datos de cotizaciones.

- **Presentation (opcional)**: Contiene la API REST.
  - `Controllers/QuoteController.cs`: Expone los endpoints para calcular y guardar cotizaciones.
  - `Program.cs`: Punto de entrada de la aplicación ASP.NET.

## Requisitos Funcionales

- Crear un método POST para calcular el pago mensual utilizando la fórmula de pago de Excel.
- Crear un método POST para guardar una cotización.
- Crear un método GET para obtener las cotizaciones por cliente.
- Las cotizaciones de arrendamiento deben incluir:
  - Nombre de cliente
  - Precio
  - Enganche
  - Plazo
  - Residual
  - Tasa

## Reglas de Negocio

- El residual no debe superar el 30% del precio.
- Si el plazo es de 12 meses, debe tener un enganche mínimo del 10%.
- Si el plazo es de 12 a 23 meses, debe tener un enganche mínimo del 7.5%.
- Si el plazo es mayor a 24 meses, debe tener un enganche mínimo del 5%.

## Cómo Ejecutar el Proyecto

1. Clona el repositorio.
2. Abre la solución en tu entorno de desarrollo.
3. Restaura las dependencias del proyecto.
4. Ejecuta el proyecto y accede a los endpoints de la API REST para probar la funcionalidad.

## Contribuciones

Las contribuciones son bienvenidas. Si deseas mejorar el proyecto, por favor abre un issue o un pull request.