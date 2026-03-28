// 3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
// a) La cantidad de valores ingresados negativos.
// b) La cantidad de valores ingresados positivos.
// c) La cantidad de múltiplos de 15.
// d) El valor acumulado de los números ingresados que son pares.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativos = 0;
            int positivos = 0;
            int multiplos15 = 0;
            int sumaPares = 0;

            Console.WriteLine("Ingrese 10 valores enteros:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Valor {i}: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor < 0)
                    negativos++;
                else if (valor > 0)
                    positivos++;

                if (valor % 15 == 0)
                    multiplos15++;

                if (valor % 2 == 0)
                    sumaPares += valor;
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Cantidad de valores negativos: {negativos}");
            Console.WriteLine($"Cantidad de valores positivos: {positivos}");
            Console.WriteLine($"Cantidad de múltiplos de 15: {multiplos15}");
            Console.WriteLine($"Suma de los números pares: {sumaPares}");

            Console.ReadKey();
        }
    }
}
