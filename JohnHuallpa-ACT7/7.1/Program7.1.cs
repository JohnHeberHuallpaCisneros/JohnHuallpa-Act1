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
        private int[] M36;
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
            M36 = new int[8];
            int sumav1 = 0;
            int contador50 = 0;
            int TM36 = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                sumav1 = sumav1 + valores[i];
            }
            Console.Write("valor total de los elementos del vector: " + sumav1);
            Console.WriteLine();
            for(int f = 0; f < valores.Length; f++)
            {
                if (valores[f] > 36)
                {
                    M36[f] = valores[f];
                }
            }

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > 36)
                {
                    TM36 = TM36 + valores[i];
                }
            }
            Console.Write("valor total de los elementos mayores a 36: " +  TM36);

            Console.WriteLine();
            foreach (int x in valores)
            {
                if (x > 50)
                {
                    contador50++;
                }
            }
            Console.Write("Cantidad de valores mayores a 50: " + contador50);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.verify_and_print();
        }
    }
}
