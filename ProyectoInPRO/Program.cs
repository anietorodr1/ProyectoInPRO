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
        //Variables de stock
        int stockProcesadores = 4;
        int stockGraficas= 3;
        int stockRam = 5;
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
                Console.WriteLine("");
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
                    Console.WriteLine("");
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
                
            }
        } while (opcion !=3);
    }
}

