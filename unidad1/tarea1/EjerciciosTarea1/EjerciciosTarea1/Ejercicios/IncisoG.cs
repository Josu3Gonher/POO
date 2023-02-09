using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que sume los números del 1 al 10 y 
 * muestre el resultado en la consola
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoG
    {
        public IncisoG() 
        {
            Console.WriteLine("Programa que suma numeros del 1 al 10");
            
            int suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                suma += i;
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("El resultado de la suma es " + suma);
        }
    }
}
