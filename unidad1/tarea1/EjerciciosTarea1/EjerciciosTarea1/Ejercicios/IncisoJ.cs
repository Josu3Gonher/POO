using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que sume los números pares del 1 al 100 y 
 * muestre el resultado en la consola
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoJ
    {
        public IncisoJ()
        {
            int limite = 100;
            int i = 1;
            int suma = 0;

            Console.WriteLine("Suma de numeros pares de 1 a 100\n" +
                "-------------------------------------");
            while (i <= limite)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine(i);
                    suma += i;
                }
                i++;
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("El resultado de la suma es: " + suma);
        }
    }
}
