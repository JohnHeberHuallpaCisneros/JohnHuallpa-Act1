// Escribir un programa en el cual se ingresen cuatro números, 
// calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Suma de los dos primeros y producto de los dos últimos ===\n");

            Console.Write("Ingrese el 1er número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el 2do número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el 3ro número: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el 4to número: ");
            int n4 = int.Parse(Console.ReadLine());
            int suma = n1 + n2;
            int producto = n3 * n4;

            Console.WriteLine($"\nSuma de los dos primeros: {suma}");
            Console.WriteLine($"Producto de los dos últimos: {producto}");
        }
    }
}
