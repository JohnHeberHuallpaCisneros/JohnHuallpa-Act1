/* 1.Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
muestre la tabla de multiplicar del mismo (los primeros 13 términos)
Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
39. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Ingrese un número del 1 al 10: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 10);

            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine(num * i);
            }
        }
    }
}
