using EjerciciosTarea1.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Que ejercicio desea ejecutar 1-11: ");
            int eleccion = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (eleccion)
            {
                case 1:
                    IncisoA incisoA = new IncisoA();
                    break;
                case 2:
                    IncisoB incisoB = new IncisoB();
                    break;
                case 3:
                    IncisoC incisoC = new IncisoC();
                    break;
                case 4:
                    IncisoD incisoD = new IncisoD();
                    break;
                case 5:
                    IncisoE incisoE = new IncisoE();
                    break;
                case 6:
                    IncisoF incisoF = new IncisoF();
                    break;
                case 7:
                    IncisoG incisoG = new IncisoG();
                    break;
                case 8:
                    IncisoH incisoH = new IncisoH();
                    break;
                case 9:
                    IncisoI incisoI = new IncisoI();
                    break;
                case 10:
                    IncisoJ incisoJ = new IncisoJ();
                    break;
                case 11:
                    IncisoK incisoK = new IncisoK();
                    break;
                default:
                    Console.WriteLine("Numero ingresado invalido");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
