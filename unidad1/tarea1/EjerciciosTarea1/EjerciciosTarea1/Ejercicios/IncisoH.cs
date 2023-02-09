using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que calcule el factorial de un número dado por el usuario
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoH
    {
        public IncisoH()
        {
            Console.Write("Ingrese el numero a calcular el factorial: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("El factorial de " + numero + " es: " + resultado);
        }
    }
}
