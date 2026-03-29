// Escribir un programa que pida ingresar la coordenada de un punto 
// en el plano (dos valores enteros x e y distintos a cero). 
// Imprimir en qué cuadrante se ubica el punto.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Determinar cuadrante en el plano ===\n");

            Console.Write("Ingresa coordenada X (distinto de 0): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingresa coordenada Y (distinto de 0): ");
            int y = int.Parse(Console.ReadLine());

            if (x == 0 || y == 0)
            {
                Console.WriteLine("\nError: Las coordenadas no pueden ser cero.");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("\nEl punto se encuentra en el 1º cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("\nEl punto se encuentra en el 2º cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("\nEl punto se encuentra en el 3º cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("\nEl punto se encuentra en el 4º cuadrante");
            }
        }
    }
}