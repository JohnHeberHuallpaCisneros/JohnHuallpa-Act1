/*
Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
primer fila con la segunda. Imprimir luego la matriz.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2
{
    class Program
    {
        private int[,] Matriz;
        public void Cargar()
        {
            Console.WriteLine("Ingresa el numero de filas: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el numero de columnas: ");
            int m = int.Parse(Console.ReadLine());
            Matriz = new int[n, m];
            for(int i = 0; i < Matriz.GetLength(0); i++)
            {
                for(int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.WriteLine("ingresa un valor: ");
                    String valor = Console.ReadLine();
                    Matriz[i, j] = int.Parse(valor);
                }
            }
        }
        public void Intercambio() 
        {
            for (int columna = 0; columna < Matriz.GetLength(1); columna++)
            {
                int aux = Matriz[0, columna];

                Matriz[0, columna] = Matriz[1, columna];

                Matriz[1, columna] = aux;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("La matriz es: ");
            for(int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.Intercambio();
            p.Imprimir();
        }
    }
}
