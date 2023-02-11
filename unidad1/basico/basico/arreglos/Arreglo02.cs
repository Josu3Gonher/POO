using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo02
    {
        public Arreglo02()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Write("Cuantas posiciones desea generar: ");
                int cantPosiciones = int.Parse(Console.ReadLine());

                Random random = new Random();
                int[] numeros = new int[cantPosiciones];

                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = random.Next(1, 100);
                    Console.WriteLine("numeros [" + i + "] = " + numeros[i]);
                }
                Console.Write("Desea continuar si/no");
                string desicion = Console.ReadLine().ToUpper();
                if (desicion == "SI")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                    Console.Write("Saliendo...");
                }
            }
        }
    }
}
