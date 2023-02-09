using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros05
    {
        public ListarNumeros05()
        {
            Console.WriteLine("Generacion de 10 numeros randoms sin repeticiones");
            Random random = new Random();

            HashSet<int> list = new HashSet<int>();

            for (int i = 1; i <= 10; i++)
            {
              int numeroRandom = random.Next(1,100);

                if (!list.Contains(numeroRandom))
                {
                    Console.WriteLine(i +"- " + numeroRandom);
                    list.Add(numeroRandom);
                }
            }

        }
    }
}
