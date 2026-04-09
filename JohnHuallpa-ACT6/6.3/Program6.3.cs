/*Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
sus datos y por último uno que imprima un mensaje si debe pagar impuestos
(si el sueldo supera a 3000).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    class Empleado
        {
            private string nombre;
            private int sueldo;

            public void Cargar()
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese sueldo: ");
                sueldo = int.Parse(Console.ReadLine());
            }

            public void Imprimir()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Sueldo: " + sueldo);
            }

            public void PagarImpuestos()
            {
                if (sueldo > 3000)
                    Console.WriteLine("Debe pagar impuestos");
                else
                    Console.WriteLine("No debe pagar impuestos");
            }

            static void Main(string[] args)
            {
                Empleado emp = new Empleado();

                emp.Cargar();
                emp.Imprimir();
                emp.PagarImpuestos();

                Console.ReadKey();
            }
    }
    
}
