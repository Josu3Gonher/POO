using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructuras_control
{
    internal class ListarNumeros01
    {
        public ListarNumeros01()
        {
            /*
             *while(condicion) si condicion es verdadera ejecutara el codigo {...} 
             */

            Console.Write("Listar numeros hasta");
            int limite = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= limite)
            {
                Console.WriteLine(i);
                i++;// se ejecuta luego de la interaccion
                // ++i => antes de la interaccion

                
            }
            
        }
    }
}
