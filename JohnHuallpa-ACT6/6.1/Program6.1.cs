/*Desarrollar una clase que represente un punto en el plano y tenga los
siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    class Punto
    {
        
        private int x;
        private int y;

        public void Cargar()
        {
            Console.Write("Ingrese valor de x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese valor de y: ");
            y = int.Parse(Console.ReadLine());
        }
        public void ImprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Tercer cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Cuarto cuadrante");
            }
            else
            {
                Console.WriteLine("El punto está sobre un eje");
            }
        }
        static void Main(string[] strings)
        {
                Punto p = new Punto();

                p.Cargar();
                p.ImprimirCuadrante();
            Console.WriteLine("se cerrará el programa al presionar cualquier tecla.");
                Console.ReadKey();
          
        }
    }
}   

