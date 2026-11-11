# STOCK PC - Gestión de una tienda de informática

## 1. Descripción del proyecto

Stock PC es una aplicación de consola desarrollada en C# para gestionar las compras de una tienda de informática.

El programa permite a los clientes comprar componentes , añadir servicios adicionales, elegir el método de entrega y realizar el pago de sus compras.

También permite consultar un resumen de la actividad de la tienda, mostrando los pedidos realizados y los ingresos obtenidos.

## 2. Funcionalidades

La aplicación cuenta con las siguientes funcionalidades:

- **Menú principal:** permite realizar una nueva compra, consultar la actividad anterior o salir del programa.
- **Datos del cliente:** solicita el nombre del cliente y comprueba que no esté vacío.
- **Selección de productos:** permite elegir entre tres componentes informáticos:
  - Procesador: 250 €.
  - Tarjeta gráfica: 400 €.
  - Memoria RAM (8 GB): 150 €.
- **Servicios adicionales:** permite añadir los siguientes servicios:
  - Instalación: 5 €.
  - Garantía: 30 €.
  - Revisión: 50 €.
- **Control de servicios:** evita que se añada un mismo servicio más de una vez en una compra.
- **Método de entrega:** permite recoger el pedido en tienda gratuitamente o recibirlo a domicilio por 5 €.
- **Descuento:** aplica un descuento del 10 % sobre el subtotal cuando se contratan los tres servicios adicionales.
- **Gestión del pago:** solicita el dinero al cliente y comprueba que sea suficiente para pagar la compra. Después calcula el cambio.
- **Ticket de compra:** muestra un justificante con los datos del cliente, los productos, los servicios y el desglose del importe.
- **Estadísticas:** permite consultar el número de pedidos realizados, los ingresos totales, el promedio de ingresos y el pedido más caro junto con el nombre del cliente.

## 3. Tecnologías utilizadas

- Lenguaje de programación: C#.
- Plataforma: .NET.
- Editor de código: Visual Studio Code.
- Control de versiones: Git y GitHub.

## 4. Estructura del proyecto

- `Program.cs`: contiene el código fuente y toda la lógica de la aplicación.
- `ProyectoInPRO.csproj`: archivo de configuración del proyecto.

## 5. Cómo ejecutar el programa

1. Descargar o clonar el repositorio de GitHub.
2. Abrir la carpeta del proyecto en Visual Studio Code.
3. Abrir una terminal dentro de la carpeta del proyecto.
4. Ejecutar el siguiente comando:

```bash
dotnet run
```

5. Seguir las instrucciones que aparecen por consola para realizar una compra o consultar la actividad de la tienda.

## 6. Información adicional

Los datos de los pedidos y las estadísticas se mantienen durante la ejecución del programa. Al cerrar la aplicación, los datos se reinician y no se guardan permanentemente.
