using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Arreglos bidimensionales (Matrices)
//numeros[0, 1] = 34;
//numeros[0, 2] = 34;
//numeros[1, 0] = 34;
//numeros[1, 1] = 34;
//numeros[1, 2] = 34;
//numeros[2, 0] = 34;
//numeros[2, 1] = 34;
//numeros[2, 2] = 34;

namespace basico.arreglos
{
    internal class Arreglo03
    {
        public Arreglo03()
        {
            int[,] numeros = new int[3, 3];

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    numeros[f, c] = f + c;
                    Console.WriteLine(numeros[f, c]);
                }
            }
        }
    }
}

