using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que pregunte al usuario si quiere comprar una hamburguesa,
 * una ensalada o una pizza y muestre el precio correspondiente
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoE
    {
        public IncisoE()
        {
            Console.WriteLine("Bienvenido\n");
            Console.Write("El menu de hoy son Hamburguesas, Ensalada o pizza" +
                "\nQue desea comer: ");
            string comida = Console.ReadLine().ToUpper();

            Console.WriteLine("--------------------------");
            switch (comida)
            {
                case "HAMBURGUESA":
                    Console.WriteLine("La hamburguesa cuesta 150 lempiras");
                    break;
                case "ENSALADA":
                    Console.WriteLine("La ensalada cuesta 100 lempiras");
                    break;
                case "PIZZA":
                    Console.WriteLine("La pizza cuesta 190 lempiras");
                    break;
                default:
                    Console.WriteLine("Error comida no disponible en el menu");
                    break;
            }
        }
    }
}
