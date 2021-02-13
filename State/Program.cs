using State.Exercise1.ConcreteState;
using State.Exercise1.Context;
using State.StateConcept;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
           // Concept
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            //Exercise 1
            var vehiculo = new Vehiculo(20, new ApagadoState());
            vehiculo.Acelerar();
            vehiculo.Contacto();
            vehiculo.Acelerar();
            vehiculo.Acelerar();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Frenar();
            vehiculo.Frenar();
            vehiculo.Frenar();
        }
    }
}
