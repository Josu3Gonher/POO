using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTarea1
{
    internal class EjemploForo
    {
        // Clase base abstracta para vehículos
        abstract class Vehiculo
        {
            protected string marca;
            protected string modelo;
            protected int año;

            // Propiedad para acceder a la marca del vehículo de forma encapsulada
            public string Marca
            {
                get { return marca; }
                set { marca = value; }
            }

            // Constructor para inicializar los atributos de la clase
            public Vehiculo(string marca, string modelo, int año)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.año = año;
            }

            // Método abstracto que deberá ser implementado por las clases hijas
            public abstract void Conducir();

            // Método virtual que puede ser sobrescrito por las clases hijas
            public virtual void Reparar()
            {
                Console.WriteLine("El vehículo ha sido reparado.");
            }
        }

        // Clase hija que hereda de Vehiculo y agrega funcionalidad propia
        class Coche : Vehiculo
        {
            private int puertas;

            // Constructor que llama al constructor de la clase base
            public Coche(string marca, string modelo, int año, int puertas) : base(marca, modelo, año)
            {
                this.puertas = puertas;
            }

            // Implementación del método abstracto de la clase base
            public override void Conducir()
            {
                Console.WriteLine("Conduciendo el coche de marca " + marca);
            }

            // Sobrescritura del método virtual de la clase base
            public override void Reparar()
            {
                Console.WriteLine("El coche ha sido reparado.");
            }
        }

        // Clase hija que hereda de Vehiculo y agrega funcionalidad propia
        class Moto : Vehiculo
        {
            private int cilindrada;

            // Constructor que llama al constructor de la clase base
            public Moto(string marca, string modelo, int año, int cilindrada) : base(marca, modelo, año)
            {
                this.cilindrada = cilindrada;
            }

            // Implementación del método abstracto de la clase base
            public override void Conducir()
            {
                Console.WriteLine("Conduciendo la moto de marca " + marca);
            }
        }

        // Programa principal
        class Program
        {
            static void Main(string[] args)
            {


                {
                    // Crear un coche y una moto
                    Coche coche = new Coche("Ford", "Fiesta", 2020, 5);
                    Moto moto = new Moto("Honda", "CBR", 2021, 600);

                    // Llamar a los métodos de los vehículos
                    coche.Conducir();
                    coche.Reparar();

                    moto.Conducir();
                    moto.Reparar();

                    Console.ReadKey();
                }
            }
        }
    }

}
