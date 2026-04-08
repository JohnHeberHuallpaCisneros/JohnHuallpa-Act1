/*
1.En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
$500, realizar un programa que lea los sueldos que cobra cada empleado e
informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
de $300. Además el programa deberá informar el importe que gasta la empresa
en sueldos al personal.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    class P1
    {
        static void Main(String[] args)
        {
            Console.Write("ingrese cantidad de empleados: ");
            int n = int.Parse(Console.ReadLine());
            int cont100_300 = 0;
            int cont300_mas = 0;
            int GastoTotal = 0;
            int i = 1;

            while (i <= n)
            {
                Console.Write("ingrese el sueldo del empleado: ");
                int sueldo = int.Parse(Console.ReadLine());
                GastoTotal += sueldo;

                if (sueldo >= 100 && sueldo <= 300)
                    cont100_300++;
                else if (sueldo > 300)
                    cont300_mas++;
                i++;
            }
            Console.WriteLine("Empleados que cobran entre 100 y 300: " + cont100_300);
            Console.WriteLine("Empleados que cobran entre 300  y más: " + cont300_mas);
            Console.WriteLine("Gasto total de la empresa:" + GastoTotal);
            Console.ReadKey();
        }
    }
}
