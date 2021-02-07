using Builder.BuilderConcept;
using Builder.Exercie1.ConcreteBuilder;
using Builder.Exercie1.Director;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            /*El código del cliente crea un objeto de construcción, se lo pasa al director y 
            luego inicia el proceso de construcción. 
            El resultado final se recupera del objeto constructor.*/
            Console.WriteLine("----------Ejercicio Conceptual----------");

            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;
            Console.WriteLine("Standard basic product:");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            /* Recuerde, el patrón Builder se puede utilizar sin una clase de Director. */

            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------- Ejercicio de prueba ----------");
            Console.WriteLine("Creando Audi.......");
            var concesionario = new Concesionario();
            var audiBuilder = new ConcreteBuilderAudi();
            concesionario.CocheBuilder = audiBuilder;
            concesionario.construirCoche();
            Console.WriteLine(audiBuilder.GetCoche());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Creando Hyundai.......");
            var hyundaiBuilder = new ConcreteBuilderHyundai();
            concesionario.CocheBuilder = hyundaiBuilder;
            concesionario.construirCoche();
            Console.WriteLine(hyundaiBuilder.GetCoche());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Sin usar director y usando parametros....");
            audiBuilder.construirMotor(5000,300);
            audiBuilder.DarNombre("Audi Q7");
            audiBuilder.construirCarroceria("4x4",7);
            Console.WriteLine(audiBuilder.GetCoche());


            Console.ReadKey();
        }
    }
}
