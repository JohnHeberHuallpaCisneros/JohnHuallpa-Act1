/*Desarrollar una clase que represente un Cuadrado y tenga los siguientes
métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    class Cuadrado
    {
        private int lado;

        public void Cargar()
        {
            Console.Write("Ingrese el valor del lado: ");
            lado = int.Parse(Console.ReadLine());
        }

        public void ImprimirPerimetro()
        {
            int perimetro = lado * 4;
            Console.WriteLine("Perímetro: " + perimetro);
        }

        public void ImprimirSuperficie()
        {
            int superficie = lado * lado;
            Console.WriteLine("Superficie: " + superficie);
        }
        static void Main(string[] strings)
        {
            Cuadrado c = new Cuadrado();
            c.Cargar();
            c.ImprimirPerimetro();
            c.ImprimirSuperficie();
            Console.WriteLine("se cerrará el programa al presionar cualquier tecla.");
            Console.ReadKey();
        }
    }
}
