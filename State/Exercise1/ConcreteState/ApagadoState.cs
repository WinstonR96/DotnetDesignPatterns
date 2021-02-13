using State.Exercise1.State;
using System;

namespace State.Exercise1.ConcreteState
{
    public class ApagadoState : Estado
    {
        public override void Acelerar()
        {
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");

        }

        public override void Contacto()
        {
            // Comprobamos que el vehiculo disponga de combustible
            if (this._context.CombustibleActual > 0)
            {
                // El vehiculo arranca -> Cambio de estado
                //estado = PARADO;
                this._context.TransitionTo(new ParadoState());
                Console.WriteLine("El vehiculo se encuentra ahora PARADO");
                this._context.VelocidadActual = 0;
            }
            else
            {
                // El vehiculo no arranca -> Sin combustible
                //estado = SIN COMBUSTIBLE
                this._context.TransitionTo(new SinCombustibleState());
                Console.WriteLine("El vehiculo se encuentra sin combustible");
            }
        }

        public override void Frenar()
        {
            Console.WriteLine("ERROR: El vehiculo esta apagado. Efectue el contacto para iniciar");
        }
    }
}
