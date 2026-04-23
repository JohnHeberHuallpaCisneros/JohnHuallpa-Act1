/*
 Se desea desarrollar un programa que permita registrar los nombres y las
calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
máxima o mínima.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Program
    {
        private string[] Alumnos;
        private int[] Notas;
        public void Carga()
        {
            Alumnos = new string[6];
            Notas = new int[6];
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del alumno: ");
                Alumnos[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del alumno: ");
                string notaingresada;
                notaingresada = Console.ReadLine();
                Notas[i] = int.Parse(notaingresada);
            }
        }
        public void NA_NB()
        {
            string alumno_destacado = Alumnos[0];
            int Nota_Alta = Notas[0];
            string alumno_mediocre = Alumnos[0];
            int Nota_Baja = Notas[0];
            int rMax = 0;
            int rMin = 0;
            for (int i = 0; i < Alumnos.Length; i++)
            {
                if (Notas[i] > Nota_Alta)
                {
                    Nota_Alta = Notas[i];
                    alumno_destacado = Alumnos[i];
                }
                if (Notas[i] < Nota_Baja)
                {
                    Nota_Baja = Notas[i];
                    alumno_mediocre = Alumnos[i];
                }
            }
            for (int i = 0; i < Alumnos.Length; i++)
            {
                if (Nota_Alta == Notas[i])
                {
                    rMax++;
                }
                if (Nota_Baja == Notas[i])
                {
                    rMin++;
                }
            }
            Console.WriteLine("El alumno con la nota más alta es: " + alumno_destacado + (" con: ") + Nota_Alta);
            Console.WriteLine("El alumno con la nota más baja es: " + alumno_mediocre + (" con: ") + Nota_Baja);
            if (rMax > 1)
            {
                Console.WriteLine("La nota alta entre los alumnos se repite: " + rMax);
            }
            else
            {
                Console.WriteLine("La nota alta no se repite");
            }
            if (rMin > 1)
            {
                Console.WriteLine("La nota baja entre los alumnos se repite: " + rMin);
            }
            else
            {
                Console.WriteLine("La nota baja no se repite");
            }
            Console.ReadKey();
        }
     
            static void Main(string[] args)
            {
                Program p = new Program();
                p.Carga();
                p.NA_NB();
            }
        
}   }
