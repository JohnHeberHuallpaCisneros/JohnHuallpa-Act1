// Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
// (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo del perímetro de un cuadrado ===\n");
            Console.Write("Ingrese la medida de un lado del cuadrado: ");

            int lado = int.Parse(Console.ReadLine());

            if (lado > 0)
            {
                int perimetro = lado * 4;
                Console.WriteLine($"\nEl perímetro del cuadrado es: {perimetro}");
            }
            else
            {
                Console.WriteLine("Valor no valido, introduce valor positivo ");
            }
            Console.ReadKey();
        }
    }
}
