// 1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
// muestre la tabla de multiplicar del mismo (los primeros 13 términos)
// Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número del 1 al 10: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabla de multiplicar del {numero} (primeros 13 términos):");

            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.ReadKey();
        }
    }
}