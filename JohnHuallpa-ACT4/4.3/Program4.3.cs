/* 3.Realizar un programa que acumule (sume) valores ingresados por teclado hasta
ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class P3
    {
        static void Main(String[] args)
        {
            int acumulador = 0;
            int valor;
            Console.Write("ingresa algun valor (con 9999 finaliza el programa): ");

            while (true)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor == 9999)
                {
                    break;
                }
                acumulador += valor;
            }
            Console.WriteLine("valor acumulado= " + acumulador);
            if (acumulador > 0)
                Console.WriteLine("El valor es mayor a 0");
            else if (acumulador < 0)
                Console.WriteLine("El valor es menor a 0");
            else
                Console.WriteLine("el valor es 0");
        }
    }
}