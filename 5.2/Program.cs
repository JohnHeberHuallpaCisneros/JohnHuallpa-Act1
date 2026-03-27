/* 2. Realizar un programa que lea los lados de n triángulos, e informar:
a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
b) Cantidad de triángulos de cada tipo.
c) Tipo de triángulo que posee menor cantidad. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Cantidad de triángulos: ");
            n = int.Parse(Console.ReadLine());

            int equilateros = 0, isosceles = 0, escalenos = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Triángulo " + i);

                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                if (a == b && b == c)
                {
                    Console.WriteLine("Equilátero");
                    equilateros++;
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Isósceles");
                    isosceles++;
                }
                else
                {
                    Console.WriteLine("Escaleno");
                    escalenos++;
                }
            }

            Console.WriteLine("Equiláteros: " + equilateros);
            Console.WriteLine("Isósceles: " + isosceles);
            Console.WriteLine("Escalenos: " + escalenos);

            if (equilateros < isosceles && equilateros < escalenos)
                Console.WriteLine("Menor cantidad: Equiláteros");
            else if (isosceles < escalenos)
                Console.WriteLine("Menor cantidad: Isósceles");
            else
                Console.WriteLine("Menor cantidad: Escalenos");
        }
    }
}
