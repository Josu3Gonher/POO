using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class CondicionIf
    {
        public CondicionIf()
        {
            Console.WriteLine("Condicion");
            Console.WriteLine("------------------");

            Console.WriteLine("\nIngrese su edad:");
            int edad = int.Parse(Console.ReadLine());

            /*
             * Operadores Logicos
             * == para comparar
             * = asignar valor
             * > mayor que
             * > menor que
             * >= mayor o igual que
             * <= menor o igual que
             * != distinto de
             * 
             * Compuertas Logicas
             * && = compuerta logica AND o y
             * || = compuerta logica OR u o
             */

            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }

            if (edad >= 16 && edad <=18)
            {
                Console.WriteLine("Puede participar en la seleccion sub-18");
            }
            else
            {
                Console.WriteLine("Usted no puede participar en la seleccion Sub-18");
            }
        }
    }
}
