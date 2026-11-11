namespace StockPC;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Gestion pedidos e inventario
        // Variables por cliente
        int operacionesRealizadas = 0;
        decimal totalIngresos = 0;
        decimal operacionMasCara=0;
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
                decimal precioNormal = 0;
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
                    precioNormal = 250m;
                }else if (eleccionProducto == 2)
                {
                    producto = "Tarjeta Grafica";
                    precioNormal = 400m;
                } else
                {
                    producto = "Memoria RAM(8gb)";
                    precioNormal = 150m;
                }
                //Fase 3: Servicios adicionales
                bool servicioInstalacion = false;
                bool servicioGarantia = false;
                bool servicioRevision = false;

                int opcionServicio;
                int totalServicios = 0;
                decimal precioServicios = 0;

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("---Servicios Adicionales---");
                    Console.WriteLine("1. Instalacion: 5€");
                    Console.WriteLine("2. garantia: 30€");
                    Console.WriteLine("3. revision: 50€");
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
                                precioServicios += 5m;
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
                                precioServicios += 30m;
                                Console.WriteLine("Servicio de garantia añadido");
                            }
                            else
                            {
                                Console.WriteLine("Ya has seleccionado este servicio");
                            }
                            break;
                        case 3:
                            if (!servicioRevision)
                            {
                                servicioRevision = true;
                                totalServicios++;
                                precioServicios += 50m;
                                Console.WriteLine("Servicio de revision añadido");
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
                //Fase 4: Entrega
                int opcionEntrega;
                string formaEntrega;
                string direccionEntrega = "";
                decimal precioReparto = 0;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("---Entrega---");
                    Console.WriteLine("1. Recoger en tienda: 0€");
                    Console.WriteLine("2. Envio a domicilio: 5€");
                    Console.Write("eligue una opcion: ");
                    opcionEntrega = int.Parse(Console.ReadLine()!);
                    if (opcionEntrega < 1 || opcionEntrega > 2)
                    {
                        Console.WriteLine("Opcion no valida, intenta de nuevo");
                    }
                }while (opcionEntrega < 1 || opcionEntrega > 2);
                if (opcionEntrega == 1)
                {
                    formaEntrega = "Recoger en tienda";
                } else
                {
                    formaEntrega = "Envio a domicilio";
                    precioReparto = 5m;
                }
                do
                {
                    Console.Write("ingrese la direccion de entrega: ");
                    direccionEntrega = Console.ReadLine()??"";
                    if (direccionEntrega.Trim() == "")
                    {
                        Console.WriteLine("La direccion no puede estar vacia, intenta de nuevo");
                    }
                }while (direccionEntrega.Trim() == "");
                //Fase 5: Resumen de la compra + Descuento
                decimal subPrecioTotal = precioNormal + precioServicios;
                decimal descuento = 0;
                if (totalServicios == 3)
                {
                    descuento = subPrecioTotal * 0.10m;
                }
                decimal precioTotal = subPrecioTotal - descuento + precioReparto;
                Console.WriteLine();
                Console.WriteLine("---Resumen de la compra---");
                Console.WriteLine("Componente seleccionado + servicios: " + subPrecioTotal.ToString("F2") + "€");
                Console.WriteLine("Descuento aplicado: " + descuento.ToString("F2") + "€");
                Console.WriteLine("Precio Reparto: " + precioReparto.ToString("F2") + "€");
                Console.WriteLine("Precio total: " + precioTotal.ToString("F2") + "€");
                //Fase 6: Cobro de la compra
                decimal dineroRecibido = 0;
                do
                {
                    Console.Write("Dinero recibido del cliente:");
                    dineroRecibido = Convert.ToDecimal(Console.ReadLine()!);
                    if (dineroRecibido < precioTotal)
                    {
                        Console.WriteLine("El dinero recibido es menor al precio total, Te faltan: " + (precioTotal - dineroRecibido).ToString("F2") + "€");
                        Console.Write("Por favor, ingrese más dinero: ");
                    }
                } while (dineroRecibido < precioTotal);
                decimal cambio = dineroRecibido - precioTotal;
                
            }
        } while (opcion !=3);
    }
}

