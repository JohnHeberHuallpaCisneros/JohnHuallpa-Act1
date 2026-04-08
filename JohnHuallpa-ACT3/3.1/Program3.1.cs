/* Realizar un programa que pida cargar una fecha cualquiera,
luego verificar si dicha fecha corresponde a Navidad.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Verifica si es Navidad ===\n");

            Console.Write("Ingrese el día (1-31): ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mes (1-12): ");
            int mes = int.Parse(Console.ReadLine());

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("\n¡Feliz Navidad!");
            }
            else
            {
                Console.WriteLine("\nLa fecha ingresada NO es la de Navidad.");
            }
        }
    }
}