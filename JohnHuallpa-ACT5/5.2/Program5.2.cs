// 2. Realizar un programa que lea los lados de n triángulos, e informar:
// a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
// iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
// b) Cantidad de triángulos de cada tipo.
// c) Tipo de triángulo que posee menor cantidad.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de triángulos: ");
            int n = int.Parse(Console.ReadLine());

            int equilateros = 0;
            int isosceles = 0;
            int escalenos = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTriángulo {i}:");

                Console.Write("Lado 1: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Lado 2: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Lado 3: ");
                int c = int.Parse(Console.ReadLine());

                string tipo;
                if (a == b && b == c)
                {
                    tipo = "Equilátero";
                    equilateros++;
                }
                else if (a == b || b == c || a == c)
                {
                    tipo = "Isósceles";
                    isosceles++;
                }
                else
                {
                    tipo = "Escaleno";
                    escalenos++;
                }

                Console.WriteLine($"Tipo: {tipo}");
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Equiláteros: {equilateros}");
            Console.WriteLine($"Isósceles: {isosceles}");
            Console.WriteLine($"Escalenos: {escalenos}");

            if (equilateros <= isosceles && equilateros <= escalenos)
                Console.WriteLine("El tipo con menor cantidad es: Equilátero");
            else if (isosceles <= equilateros && isosceles <= escalenos)
                Console.WriteLine("El tipo con menor cantidad es: Isósceles");
            else
                Console.WriteLine("El tipo con menor cantidad es: Escaleno");

            Console.ReadKey();
        }
    }
}