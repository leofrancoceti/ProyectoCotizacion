

# Proyecto Cotización

Este proyecto es una solución en C# que implementa una arquitectura de tipo Onion (Clean Architecture) para calcular cotizaciones de arrendamiento. El enfoque principal es la claridad del diseño, la separación de responsabilidades y la mantenibilidad del código para la prueba Tecnica, el enfoque es mas quue nada de arquit¿ectura.

## Objetivo 
🖥

🎯 Objetivo
Construir una solución en C# con arquitectura Onion (Onion Architecture o Clean
Architecture), capaz de calcular una cotización de arrendamiento, considerando
reglas de negocio predefinidas y principios de diseño limpio. El foco está en la
claridad del diseño, separación de responsabilidades y mantenibilidad del código.
🔨 Tecnologías esperadas
Plataforma: .NET 6 o superior
Lenguaje: C#
Persistencia: Sin base de datos real (datos en memoria o mocks)
Exposición: API REST
🗒 Estructura esperada
La solución debe organizarse en capas:
1. Domain (o Core)
Entidades del dominio: Quote y Client.
Reglas de negocio: métodos de cálculo.
2. Application
Servicios (QuoteService)
Mapeo de DTOs
Validaciones (QuoteValidator)
3. Infrastructure
Simulaciones de fuentes de datos (usar mock)
Proyecto Entrevista .NET 1
4. Presentation (opcional)
Proyecto de ASP.NET
Permite probar funcionalidad desde un endpoint
✅ Requisitos funcionales
Crear metodo post para calcular el pago mensual usando fórmula de pago
excel.
Crear metodo post para guardar una cotización.
Crear metodo get para obtener las cotizaciones por cliente.
Crear cotizaciones de arrendamiento con estos campos:
Nombre de cliente
Precio
Enganche
Plazo
Residual
Tasa
Reglas a aplicar:
1. El residual no debe superar el 30% del precio.
2. Si el plazo es de 12 meses debera tener un enganche minimo de 10%.
3. Si el plazo es de 12 - 23 meses debera tener un enganche minimo del
7.5%.
4. Si el pazo es mayor a 24 meses debera tener un enganche minimo del 5%.
🎖 Entrega esperada
Solución .NET en carpeta organizada (sin base de datos).
Código con comentarios de calidad profesional.
Explica en comentarios: qué hace cada clase, propiedad y método.
Proyecto Entrevista .NET 2
El diseño de la solucion permite que sea escalable como por ejemplo que en
un futuro se agreguen más reglas a las cotizaciónes.
Proyecto Entrevista .NET 3

## Espacios 
Cada espacio de comentario lo pide el problema
## Como extra 
La prueba tecnica me dieron algunas ideas para poder juntarlo con React (Pero se que se necesitan investigar más cosas)

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

## Agradezco su valioso timepo y estoy a la orden
1: Leonardo Franco Pérez
2: leofranco300@gmail.com


