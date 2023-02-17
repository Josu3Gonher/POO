using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escribir un programa que solicite al usuario una lista de 
 * números enteros y encuentre el número más común en la lista.
 */

namespace examen1.Ejercicios
{
    internal class Inciso2
    {
        public Inciso2()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Write("Ingrese una lista de numeros separados por espacios: ");
                string entradaNumeros = Console.ReadLine();

                int[] numeros = entradaNumeros.Split(' ').Select(int.Parse).ToArray();

                int numeroComun = numeros.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;

                Console.WriteLine("");
                Console.WriteLine("El numero mas comun es:" + numeroComun);

                Console.Write("Desea continuar si/no: ");
                string desicion = Console.ReadLine().ToUpper();

                if (desicion == "SI")
                {
                    continuar = true;
                    Console.WriteLine("Continuamos :)");
                }
                else
                {
                    continuar = false;
                    Console.WriteLine("Saliendo....");
                }
            }
            
        }
    }
}
