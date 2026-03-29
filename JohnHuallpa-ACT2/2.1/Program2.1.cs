// 1. Realizar un programa que lea por teclado dos números, 
// si el primero es mayor al segundo informar su suma y diferencia, 
// en caso contrario informar el producto y la división del primero respecto al segundo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparación de dos números");

            Console.Write("Ingrese el primer número: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Valor no válido.");
                return;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Valor no válido.");
                return;
            }

            if (a > b)
            {
                int suma = a + b;
                int diferencia = a - b;

                Console.WriteLine($"El primero es mayor.");
                Console.WriteLine($"Suma:        {suma}");
                Console.WriteLine($"Diferencia:  {diferencia}");
            }
            else if (a < b)
            {
                int producto = a * b;
                
                double division = (b != 0) ? (double)a / b : double.NaN;

                Console.WriteLine($"El segundo es mayor.");
                Console.WriteLine($"Producto:    {producto}");

                if (b == 0)
                    Console.WriteLine("División:No se puede dividir por cero");
                else
                    Console.WriteLine($"División: {division:F2}");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
        }
    }
}
