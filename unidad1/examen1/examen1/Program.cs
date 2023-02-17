using examen1.Ejercicios;
using System;


namespace examen1.Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Que ejercicio desea ejecutar 1-3: ");
            int eleccion = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (eleccion)
            {
                case 1:
                    Inciso1 inciso1 = new Inciso1();
                    break;
                case 2:
                    Inciso2 inciso2 = new Inciso2();
                    break;
                case 3:
                    Inciso3 inciso3 = new Inciso3();
                    break;

                default:
                    Console.WriteLine("Numero ingresado invalido");
                    break;
            }
        }

    }
}