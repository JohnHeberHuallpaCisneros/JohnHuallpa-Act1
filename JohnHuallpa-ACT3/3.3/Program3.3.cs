// Se ingresan por teclado tres números, 
// si todos los valores ingresados son menores a 10, 
// imprimir "Todos los números son menores a diez"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Todos menores a 10 ===\n");

            Console.Write("Ingrese el primer numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 < 10 && n2 < 10 && n3 < 10)
            {
                Console.WriteLine("\nTodos los numeros son menores a diez");
            }
            else
            {
                Console.WriteLine("\nNo todos los numeros son menores a diez");
            }
            Console.ReadKey();
        }
    }
}
