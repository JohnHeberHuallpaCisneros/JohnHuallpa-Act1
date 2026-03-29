// 2. Se ingresan seis notas de un alumno, 
// si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Promedio de Notas ===\n");

            int nota1, nota2, nota3, nota4, nota5, nota6;

            Console.Write("Ingrese la nota 1: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 3: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 4: ");
            nota4 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 5: ");
            nota5 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 6: ");
            nota6 = int.Parse(Console.ReadLine());

            int suma = nota1 + nota2 + nota3 + nota4 + nota5 + nota6;
            int promedio = suma / 6;

            Console.WriteLine("\nEl promedio es: " + promedio);

            if (promedio >= 7)
            {
                Console.WriteLine("¡Promocionado!");
            }
            else
            {
                Console.WriteLine("No promocionado.");
            }
        }
    }
}
