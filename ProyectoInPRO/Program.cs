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
                
            }
        } while (opcion !=3);
    }
}

