// 4. Se cuenta con la siguiente información:
// Las edades de 20 estudiantes del turno mañana.
// Las edades de 30 estudiantes del turno tarde.
// Las edades de 15 estudiantes del turno noche.
// Las edades de cada estudiante deben ingresarse por teclado.
// a) Obtener el promedio de las edades de cada turno (tres promedios)
// b) Imprimir dichos promedios (promedio de cada turno)
// c) Mostrar por pantalla un mensaje que indique cuál es el turno con mayor promedio de edad.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaManana = 0;
            int sumaTarde = 0;
            int sumaNoche = 0;

            // Turno Mañana
            Console.WriteLine("Ingrese las edades del turno Mañana (20 estudiantes):");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Edad estudiante {i}: ");
                sumaManana += int.Parse(Console.ReadLine());
            }

            // Turno Tarde
            Console.WriteLine("\nIngrese las edades del turno Tarde (30 estudiantes):");
            for (int i = 1; i <= 30; i++)
            {
                Console.Write($"Edad estudiante {i}: ");
                sumaTarde += int.Parse(Console.ReadLine());
            }

            // Turno Noche
            Console.WriteLine("\nIngrese las edades del turno Noche (15 estudiantes):");
            for (int i = 1; i <= 15; i++)
            {
                Console.Write($"Edad estudiante {i}: ");
                sumaNoche += int.Parse(Console.ReadLine());
            }

            double promManana = (double)sumaManana / 20;
            double promTarde = (double)sumaTarde / 30;
            double promNoche = (double)sumaNoche / 15;

            Console.WriteLine("\n--- Promedios de Edades ---");
            Console.WriteLine($"Promedio Mañana: {promManana:F2}");
            Console.WriteLine($"Promedio Tarde: {promTarde:F2}");
            Console.WriteLine($"Promedio Noche: {promNoche:F2}");

            if (promManana > promTarde && promManana > promNoche)
                Console.WriteLine("El turno con mayor promedio de edad es: Mañana");
            else if (promTarde > promManana && promTarde > promNoche)
                Console.WriteLine("El turno con mayor promedio de edad es: Tarde");
            else
                Console.WriteLine("El turno con mayor promedio de edad es: Noche");

            Console.ReadKey();
        }
    }
}