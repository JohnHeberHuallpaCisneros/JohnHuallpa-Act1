// Actividad 5: Realizar la carga del radio de un círculo, 
// mostrar por pantalla la circunferencia y el área del mismo.
// (circunferencia = 2 * π * radio)    (área = π * radio²)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculos de un círculo ===\n");
            Console.Write("Ingresar radio del círculo: ");

            int radio = int.Parse(Console.ReadLine());

            if (radio > 0)
            {
                int circunferencia = (int)(2 * Math.PI * radio);
                int area = (int)(Math.PI * radio * radio);

                Console.WriteLine($"\nCircunferencia: {circunferencia}");
                Console.WriteLine($"Área: {area}");
            }
            else
            {
                Console.WriteLine("El radio debe ser positivo.");
            }
        }
    }
}
