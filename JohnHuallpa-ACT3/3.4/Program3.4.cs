// Se ingresan por teclado tres números, 
// si al menos uno de los valores ingresados es menor a 10, 
// imprimir "Alguno de los números es menor a diez".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Alguno menor a 10 ===\n");

            Console.Write("Ingrese el primer numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 < 10 || n2 < 10 || n3 < 10)
            {
                Console.WriteLine("\nAlguno de los numeros es menor a diez");
            }
            else
            {
                Console.WriteLine("\nNinguno de los numeros es menor a diez");
            }
        }
    }
}