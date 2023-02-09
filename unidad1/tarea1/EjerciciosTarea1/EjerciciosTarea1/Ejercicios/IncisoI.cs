using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que pregunte al usuario si quiere continuar y 
 * muestre un mensaje en la consola hasta que responda "no"
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoI
    {
        public IncisoI()
        {
            bool continuar = true;

            while (continuar)
            {
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
