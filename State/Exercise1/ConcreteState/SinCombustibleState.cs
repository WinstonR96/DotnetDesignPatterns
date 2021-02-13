using State.Exercise1.State;
using System;

namespace State.Exercise1.ConcreteState
{
    public class SinCombustibleState : Estado
    {
        public override void Acelerar()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

        public override void Contacto()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }

        public override void Frenar()
        {
            Console.WriteLine("ERROR: El vehiculo se encuentra sin combustible");
        }
    }
}
