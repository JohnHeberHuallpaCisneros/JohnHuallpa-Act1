/*
Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
etc.)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10._3
{
    class Program
    {
        private int[,] Matriz;
        private int filas;
        private int columnas;

        public void CargarMatriz()
        {
            Console.Write("Ingrese cantidad de filas: ");
            filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de columnas: ");
            columnas = int.Parse(Console.ReadLine());
            Matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese valor [{i},{j}]: ");
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void ImprimirMatriz()
        {
            Console.WriteLine("Matriz: ");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public void MostrarVertices()
        {
            Console.WriteLine("Vertices de la matriz:");

            Console.WriteLine("Superior izquierdo: " + Matriz[0, 0]);

            Console.WriteLine("Superior derecho: " +
                Matriz[0, columnas - 1]);

            Console.WriteLine("Inferior izquierdo: " +
                Matriz[filas - 1, 0]);

            Console.WriteLine("Inferior derecho: " +
                Matriz[filas - 1, columnas - 1]);
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.CargarMatriz();
            p.ImprimirMatriz();
            p.MostrarVertices();

            Console.ReadKey();
        }
    }
}