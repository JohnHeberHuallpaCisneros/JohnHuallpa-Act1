// Se ingresan tres valores por teclado, 
// si todos son iguales se imprime la suma del primero con el segundo 
// y a este resultado se lo multiplica por el tercero.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class p2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Suma y multiplicación si todos son iguales ===\n");

            Console.Write("Ingresa el primer numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer numero: ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                int resultado = (a + b) * c;
                Console.WriteLine("\nTodos los numeros son iguales.");
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("\nLos numeros no son todos iguales.");
            }
            Console.Write("La suma de los 3 números ingresados es: " + (a+b+c));
        }
    }
}