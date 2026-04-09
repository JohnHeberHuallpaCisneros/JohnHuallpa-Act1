/*Implementar la clase operaciones. Se deben cargar dos valores enteros,
calcular su suma, resta, multiplicación y división, cada una en un método,
imprimir dichos resultados.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    class Operaciones
    {
        private int valor1;
        private int valor2;

        public void Cargar()
        {
            Console.Write("Ingrese primer valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public int Sumar()
        {
            return valor1 + valor2;
        }

        public int Restar()
        {
            return valor1 - valor2;
        }

        public int Multiplicar()
        {
            return valor1 * valor2;
        }

        public double Dividir()
        {
            if (valor2 != 0)
                return (double)valor1 / valor2;
            else
            {
                Console.WriteLine("No se puede dividir por cero");
                return 0;
            }
        }

        public void ImprimirResultados()
        {
            Console.WriteLine("Suma: " + Sumar());
            Console.WriteLine("Resta: " + Restar());
            Console.WriteLine("Multiplicación: " + Multiplicar());
            Console.WriteLine("División: " + Dividir());
        }

        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();

            op.Cargar();
            op.ImprimirResultados();

            Console.ReadKey();
        }
    }
}
