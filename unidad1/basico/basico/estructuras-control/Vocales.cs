using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class Vocales
    {
        public Vocales()
        {
            Console.WriteLine("Nombres segun la vocal");
            Console.WriteLine("______________________\n");

            Console.WriteLine("Ingrese una vocal");
            char vocal = Console.ReadLine()[0];

            switch (vocal)
            {
                case 'a':
                    Console.WriteLine("Anabell, Aminta, Angel, Ana, Alan");
                    break;
                case 'e':
                    Console.WriteLine("Erick, Esteban, Ezequiel, Enrrique, Esmeralda");
                    break;
                case 'i':
                    Console.WriteLine("Inocencia, Ignacia, Ivan, Isis, Isabel");
                    break;
                case 'o':
                    Console.WriteLine("Orlando, Otoniel, Octavio, Oscar, Orfilia");
                    break;
                case 'u':
                    Console.WriteLine("Ulises, Ursula, Uriel, Uriana, Ublado");
                    break;
                default:
                    Console.WriteLine("La vocal no es valida");
                    break;
            }
        }
    }
}
