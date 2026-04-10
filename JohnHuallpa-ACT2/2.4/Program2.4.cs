// 4. Se cargan por teclado tres números distintos. 
// Mostrar por pantalla el mayor de ellos.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Mayor de tres números distintos ===\n");

            Console.Write("Ingrese el primer número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int c = int.Parse(Console.ReadLine());

            if (a == b || a == c || b == c)
            {
                Console.WriteLine("\nLos números deben ser distintos.");
            }
            else if (a > b && a > c)
            {
                Console.WriteLine("El mayor es: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("El mayor es: " + b);
            }
            else
            {
                Console.WriteLine("El mayor es: " + c);
            }
            Console.ReadKey();
        }
    }
}
