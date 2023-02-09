using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que muestre los números del 1 al 100 en la consola
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoF
    {
        public IncisoF() 
        {
            Console.WriteLine("Numeros del 1 al 100");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
