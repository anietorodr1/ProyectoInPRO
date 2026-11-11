namespace StockPC;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Gestion pedidos e inventario
        // Variables por cliente
        int operacionesRealizadas = 0;
        double totalIngresos = 0;
        double operacionMasCara=0;
        string ClienteMasGasto="";
        //varable de opcion
        int opcion = 0;

        // Menu

        do
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("             STOCK PC              ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nueva compra: 1");
            Console.WriteLine("ver actividad anterior: 2");
            Console.WriteLine("Salir: 3");
            Console.Write("Ingrese una opcion: ");
            opcion = int.Parse(Console.ReadLine()!);
            if (opcion == 1)
            {
                //FASE 1: Datos del cliente
                Console.WriteLine();
                Console.WriteLine("---Nuevo pedido---");
                string nombreCliente = "";
                do
                {
                    Console.Write("ingresa tu nombre:");
                    nombreCliente = Console.ReadLine()??"";
                    if (nombreCliente.Trim() =="")
                    {
                        Console.WriteLine("El nombre no puede estar vacio intenta de nuevo");
                    } 
                }while (nombreCliente.Trim() == "");
                //Fase 2: Seleccion de productos
                int eleccionProducto = 0;
                string producto;
                double precioNormal = 0;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("---Selccion de Productos---");
                    Console.WriteLine("1. Procesador: 250€");
                    Console.WriteLine("2. Tarjeta Grafica: 400€");
                    Console.WriteLine("3. Memoria RAM(8gb): 150€");
                    Console.WriteLine("selecciona un producto:");
                    eleccionProducto = int.Parse(Console.ReadLine()!);
                    if (eleccionProducto < 1 || eleccionProducto > 3)
                    {
                        Console.WriteLine("Opcion no valida, intenta de nuevo");
                    }
                }while (eleccionProducto < 1 || eleccionProducto > 3);
                if (eleccionProducto == 1)
                {
                    producto = "Procesador";
                    precioNormal = 250;
                }else if (eleccionProducto == 2)
                {
                    producto = "Tarjeta Grafica";
                    precioNormal = 400;
                } else
                {
                    producto = "Memoria RAM(8gb)";
                    precioNormal = 150;
                }
                //Fase 3: Servicios adicionales
                bool servicioInstalacion = false;
                bool servicioGarantia = false;
                bool servicioTransporte = false;

                int opcionServicio;
                int totalServicios = 0;
                double precioServicios = 0;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("---Servicios Adicionales---");
                    Console.WriteLine("1. Instalacion: 5€");
                    Console.WriteLine("2. garantia: 30€");
                    Console.WriteLine("3. Transporte: 10€");
                    Console.WriteLine("4. Finalizar eleccion");
                    Console.WriteLine();
                    Console.WriteLine("Servicios seleccionados: " + totalServicios);
                    Console.WriteLine("Precio de la compra: " + (precioNormal + precioServicios).ToString("F2") + "€");
                    Console.WriteLine("Precio Servicios seleccionados: " + precioServicios + "€");
                    Console.Write("Selecciona un servicio: ");
                    opcionServicio = int.Parse(Console.ReadLine()!);
                    switch (opcionServicio)
                    {
                        case 1:
                            if (!servicioInstalacion)
                            {
                                servicioInstalacion = true;
                                totalServicios++;
                                precioServicios += 5;
                                Console.WriteLine("Servicio de instalacion añadido");
                            }
                            else
                            {
                                Console.WriteLine("Ya has seleccionado este servicio");
                            }
                            break;
                        case 2:
                            if (!servicioGarantia)
                            {
                                servicioGarantia = true;
                                totalServicios++;
                                precioServicios += 30;
                                Console.WriteLine("Servicio de garantia añadido");
                            }
                            else
                            {
                                Console.WriteLine("Ya has seleccionado este servicio");
                            }
                            break;
                        case 3:
                            if (!servicioTransporte)
                            {
                                servicioTransporte = true;
                                totalServicios++;
                                precioServicios += 10;
                                Console.WriteLine("Servicio de transporte añadido");
                            }
                            else
                            {
                                Console.WriteLine("Ya has seleccionado este servicio");
                            }
                            break;
                        default:
                            if (opcionServicio != 4)
                            {
                                Console.WriteLine("Opcion no valida, intenta de nuevo");
                            }
                            break;
                    }
                } while (opcionServicio != 4);
            }
        } while (opcion !=3);
    }
}

