// Actividad 6: Escribir un programa que lea el peso (en kilogramos) 
// y la altura (en metros) de una persona, 
// y mostrar por pantalla su índice de masa corporal (IMC)
// IMC = peso / (altura * altura)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Cálculo del IMC ===\n");

            Console.Write("Ingrese su peso en kg: ");
            int peso = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su altura en centímetros: ");
            int alturaCm = int.Parse(Console.ReadLine());

            if (alturaCm <= 0 || peso <= 0)
            {
                Console.WriteLine("Los valores deben ser positivos.");
            }
            else
            {
                int imcEntero = (peso * 10000) / (alturaCm * alturaCm);

                Console.WriteLine($"\nSu IMC es: {imcEntero / 100}.{imcEntero % 100}");
            }
        }
    }
}
