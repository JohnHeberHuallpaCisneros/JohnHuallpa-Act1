/* 4.En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
finalizar al ingresar un valor negativo en el número de cuenta.
Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
informe:
a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
que:
Estado de la cuenta:
○ “Acreedor” si el saldo es &gt; 0.
○ “Deudor” si el saldo es &lt; 0.
○ “Nulo” si el saldo es =0.
b) La suma total de los saldos acreedores. */
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class P4
    {
        static void Main(String[] args)
        {
            int n_cuenta;
            int saldo;
            int SumAcr = 0;
            while (true)
            {
                Console.Write("ingresa su número de cuenta: ");
                n_cuenta = int.Parse(Console.ReadLine());
                if (n_cuenta < 0)
                    break;
                Console.Write("Ingresa saldo de la cuenta: ");
                saldo = int.Parse(Console.ReadLine());
                if (saldo > 0)
                {
                    Console.WriteLine("Estado: Acreedor");
                    SumAcr += saldo;
                }
                else if (saldo < 0)
                {
                    Console.WriteLine("Estado: Deudor");
                }
                else {
                    Console.WriteLine("Estado: Nulo");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Total de Acreedores= " + SumAcr);
            Console.ReadKey();
        }
    }
}