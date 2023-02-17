using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1.Ejercicios
{
    internal class Inciso1
    {
        public Inciso1()
        {
            bool continuar = true;

            while (continuar)
            {
                int[,] matriz = {
                                {1, 2, 3},
                                {4, 5, 6},
                                {7, 8, 9}
                                    };

                int menor = matriz[0, 0];
                int mayor = matriz[0, 0];

                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.WriteLine(matriz[f, c]);
                        if (matriz[f, c] < menor)
                        {
                            menor = matriz[f, c];
                        }

                        if (matriz[f, c] > mayor)
                        {
                            mayor = matriz[f, c];
                        }

                    }
                }
            Console.WriteLine("El numero menor es:" + menor);
            Console.WriteLine("El numero meyor es:" + mayor);

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