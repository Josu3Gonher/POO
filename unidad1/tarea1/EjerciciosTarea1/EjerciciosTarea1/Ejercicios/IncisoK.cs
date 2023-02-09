using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que muestre la tabla de multiplicar 
 * del número dado por el usuario hasta el 10
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoK
    {
        public IncisoK()
        {
            Console.Write("Ingrese la tabla que desea imprimir: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("" + numero + " x " + i + " = " + numero * i);
                i++;
            }
        }
    }
}
