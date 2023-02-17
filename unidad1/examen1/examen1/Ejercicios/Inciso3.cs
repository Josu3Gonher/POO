using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Escribir un programa que genere una matriz cuadrada de tamaño N (ingresado por el usuario),
 *donde cada elemento de la matriz sea un número aleatorio entre 1 y 100.
 *Luego, el programa deberá imprimir en la consola la suma de cada una de las filas 
 *y la suma de cada una de las columnas de la matriz. 
 */


namespace examen1.Ejercicios
{
    internal class Inciso3
    {
        public Inciso3()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("De cuanto desea generar la matriz: ");
                int tamaño = int.Parse(Console.ReadLine());
                int[,] matriz = new int[tamaño, tamaño];

                Random numeroRamdon = new Random();
                int[] sumaFilas = new int[tamaño];
                int[] sumaColumnas = new int[tamaño];

                for (int f = 0; f < tamaño; f++)
                {
                    for (int c = 0; c < tamaño; c++)
                    {
                        matriz[f, c] = numeroRamdon.Next(1, 100);
                    }
                }

                Console.WriteLine("Matriz generada");
                for (int f = 0; f < tamaño; f++)
                {
                    for (int c = 0; c < tamaño; c++)
                    {
                        Console.Write(matriz[f, c] + " ");
                    }
                    Console.WriteLine();
                }

                // Suma de filas
                for (int f = 0; f < tamaño; f++)
                {
                    int sumaFila = 0;
                    for (int c = 0; c < tamaño; c++)
                    {
                        sumaFila += matriz[f, c];
                    }
                    sumaFilas[f] = sumaFila;
                }
                // Suma de columnas
                for (int c = 0; c < tamaño; c++)
                {
                    int sumaColumna = 0;
                    for (int f = 0; f < tamaño; f++)
                    {
                        sumaColumna += matriz[f, c];
                    }
                    sumaColumnas[c] = sumaColumna;
                }

                Console.WriteLine(" Resultado Suma de filas:");
                for (int f = 0; f < tamaño; f++)
                {
                    Console.WriteLine($"Fila {f + 1}: {sumaFilas[f]}");
                }

                Console.WriteLine("\nSuma de columnas:");
                for (int c = 0; c < tamaño; c++)
                {
                    Console.WriteLine($"Columna {c + 1}: {sumaColumnas[c]}");
                }

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