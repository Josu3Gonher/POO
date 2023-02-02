using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.tipo_datos
{
    internal class Promedio
    {
        public Promedio()
        {
            /*
         * menos de 70 pts => reprobado
         * mas de 70 => aprobado
         * mas de 80 => bueno
         * mas de 90 => sobresaliente
         */
            Console.WriteLine("Ingrese la nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());

            double suma = nota1 + nota2 + nota3;
            double promedio = suma / 3;

            if (promedio < 70)
            {
                Console.WriteLine("REPROBADO :( ");
            }
            else
            {
                if (promedio >= 70 && promedio < 80)
                {
                    Console.WriteLine("APROBADO");
                }
            }
            if (promedio >= 80 && promedio < 90)
            {
                Console.WriteLine("BUENO");
            }
            else
            {
                if (promedio >= 90 && promedio <= 100)
                {
                    Console.WriteLine("SOBRESALIENTE :)");
                }
            }

            Console.WriteLine("Su promedio es :" + promedio);
        }
    }
}
