using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que pregunte al usuario su género y muestre un mensaje 
 * en la consola si es hombre o mujer
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoC
    {
        public IncisoC() 
        {
            Console.WriteLine("Bienvenido\n");
            Console.Write("Por favor ingrese su género (M/F): ");
            string genero = Console.ReadLine().ToUpper();

            Console.WriteLine("-------------------------------------");

            if (genero == "M")
            {
                Console.WriteLine("Hombre");
            }
            else if (genero == "F")
            {
                Console.WriteLine("Mujer");
            }
        }
    }
}
