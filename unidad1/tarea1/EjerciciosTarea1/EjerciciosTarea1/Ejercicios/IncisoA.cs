using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * programa que pregunte al usuario por un número y 
 * determine si es positivo, negativo o cero
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoA
    {
        public IncisoA()
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El numero " + numero + " es positivo");
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("El numero que ingreso es 0");
                }
                else
                {
                    Console.WriteLine("El numero " + numero + " es negativo");

                }
            }
        }
    }
}
