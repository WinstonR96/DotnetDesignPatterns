using Flyweight.Exercise_1.FlyweightFactory;
using Flyweight.Flyweight;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ////El código del cliente generalmente crea un montón de flyweight precargados en la 
            ////etapa de inicialización de la aplicación.
            //// Arbitrary extrinsic state

            //int extrinsicstate = 22;

            //FlyweightFactory factory = new FlyweightFactory();

            //// Work with different flyweight instances

            //var fx = factory.GetFlyweight("X");
            //fx.Operation(--extrinsicstate);

            //var fy = factory.GetFlyweight("Y");
            //fy.Operation(--extrinsicstate);

            //var fz = factory.GetFlyweight("Z");
            //fz.Operation(--extrinsicstate);

            //var fa = factory.GetFlyweight("A");
            //fa.Operation(--extrinsicstate);

            //UnsharedConcreteFlyweight fu = new

            //  UnsharedConcreteFlyweight();

            //fu.Operation(--extrinsicstate);

            // Ejercicio

            // Definimos los tipos de árbol

            string[] tipos = { "pino", "abeto", "sauce" };

            // Obtenemos el número de árboles a dibujar por parámetro
            Random r = new Random();
            int num_arboles = r.Next(tipos.Length);

            // Creamos la fábrica de Árboles

            FabricaDeArboles f = new FabricaDeArboles();

            for (int i = 0; i < num_arboles; i++)

            {

                f.GetArbol(tipos[r.Next(tipos.Length)]).dibujar(r.Next(tipos.Length), r.Next(tipos.Length), r.Next(tipos.Length));

            }


            Console.ReadKey();
        }
    }
}

