// 3. Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) 
// mostrar un mensaje indicando si el número tiene uno o dos dígitos.
// (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Uno o dos dígitos (1-99) ===\n");

            Console.Write("Ingrese un número entero positivo (1 a 99): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1 && numero <= 99)
            {
                if (numero >= 10)
                {
                    Console.WriteLine("El número tiene 2 dígitos.");
                }
                else
                {
                    Console.WriteLine("El número tiene 1 dígito.");
                }
            }
            else
            {
                Console.WriteLine("El número debe estar entre 1 y 99 inclusive.");
            }
            Console.ReadKey();
        }
    }
}

