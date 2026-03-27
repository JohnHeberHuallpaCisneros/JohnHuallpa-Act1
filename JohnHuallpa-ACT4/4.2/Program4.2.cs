//2.Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
//(No se ingresan valores por teclado)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class P2
    {
        static void Main(String[] args)
        {
            int avance = 11;
            int contador = 1;
            while (contador <= 25)
            {
                if (contador < 25)
                    Console.Write(avance + " - ");
                else
                    Console.Write(avance);
                avance += 11;
                contador++;
            }
        }
    }
}