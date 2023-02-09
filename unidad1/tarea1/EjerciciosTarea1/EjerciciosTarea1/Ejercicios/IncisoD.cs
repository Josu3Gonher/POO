using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un programa que pregunte al usuario un número del 1 al 7 y muestre 
 * el día de la semana correspondiente
 */

namespace EjerciciosTarea1.Ejercicios
{
    internal class IncisoD
    {
        public IncisoD()
        {
            Console.WriteLine("Bienvenido\n");
            Console.Write("Ingrese un numero del 1 al 7: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");

            switch (numero)
            {
                case 1:
                    Console.WriteLine("El numero " + numero + " corresponde al dia Lunes");
                    break;
                case 2:
                    Console.WriteLine("El numero " + numero + " corresponde al dia Martes");
                    break;
                case 3:
                    Console.WriteLine("El numero " + numero + " corresponde al dia Miercoles");
                    break;
                case 4:
                    Console.WriteLine("El numero " + numero + " corresponde al dia Jueves");
                    break;
                case 5:
                    Console.WriteLine("El numero " + numero + " corresponde al dia Viernes");
                    break;
                case 6:
                    Console.WriteLine("El numero " + numero + " corresponde al dia Sabado");
                    break;
                case 7:
                    Console.WriteLine("El numero " + numero + " corresponde al dia Domingo");
                    break;

                default:
                    Console.WriteLine("El numero ingresado es invalido");
                    break;
            }
        }
    }
}
