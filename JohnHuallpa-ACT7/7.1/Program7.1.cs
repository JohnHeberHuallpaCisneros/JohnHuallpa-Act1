/*
 Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
El valor acumulado de todos los elementos del vector.
El valor acumulado de los elementos del vector que sean mayores a 36.
Cantidad de valores mayores a 50.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        private int[] valores;
        public void Cargar()
        {
            valores = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese un valor: ");
                string ingresado;
                ingresado = Console.ReadLine();
                valores[i] = int.Parse(ingresado);
            }
        }
        public void verify_and_print()
        {
         int sumaTotal = 0;
         int sumaMayores36 = 0;
         int contadorMayores50 = 0;
         
         for (int i = 0; i < valores.Length; i++)
            {
                sumaTotal = sumaTotal + valores[i];

                if (valores[i] > 36)
                    sumaMayores36 = sumaMayores36 + valores[i];

                if (valores[i] > 50)
                    contadorMayores50++;
            }
            Console.WriteLine("Valor acumulado de todos los elementos: " + sumaTotal);
            Console.WriteLine("Valor acumulado de elementos mayores a 36: " + sumaMayores36);
            Console.WriteLine("Cantidad de valores mayores a 50: " + contadorMayores50);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.verify_and_print();
        }
    }
}
