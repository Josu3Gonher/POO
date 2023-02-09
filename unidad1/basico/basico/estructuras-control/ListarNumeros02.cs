using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros02
    {
        public ListarNumeros02()
        {
            
            int i = 0;
            char desicion = 's';

            Console.Write("Ingresar numros hasta: ");
            int limite = int.Parse(Console.ReadLine());

            while (i <= limite && desicion == 's')
            {
                Console.WriteLine(i+1);
                i++;

                if (i == limite)
                {
                    Console.WriteLine("----------------------");
                    Console.Write("Desea Continuar: ");
                    desicion = Console.ReadLine()[0];

                    if (desicion == 's')
                    {
                        Console.Write("Ingresar numeros hasta: ");
                        limite = int.Parse(Console.ReadLine());
                        desicion = 's';
                        i = 0;
                    }
                }
            }
        }
    }
}
