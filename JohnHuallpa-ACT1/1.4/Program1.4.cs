// Actividad 4: Se debe desarrollar un programa que pida el ingreso del precio 
// de un artículo y la cantidad que lleva el cliente. 
// Mostrar lo que debe abonar el comprador.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo del monto a total ===\n");
            Console.Write("Ingrese el precio de unidad del artículo: ");
            int precio = int.Parse(Console.ReadLine());

            Console.Write("Ingresar la cantidad del cliente: ");
            int cantidad = int.Parse(Console.ReadLine());

            int total = precio * cantidad;

            Console.WriteLine($"\nEl cliente debe pagar: ${total:F2}");
            Console.ReadKey();
        }
    }
}
