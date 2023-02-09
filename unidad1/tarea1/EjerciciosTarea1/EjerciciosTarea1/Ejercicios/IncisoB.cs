using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir un programa que pregunte al usuario por dos números
 * y determine cuál es el mayor
*/

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoB
    {
        public IncisoB()
        {
            Console.WriteLine("Digite 2 numeros: ");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");

            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es: " + numero1);
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + numero2);
            }
        }
    }
}
