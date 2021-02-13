using State.Exercise1.State;
using System;

namespace State.Exercise1.ConcreteState
{
    public class ParadoState : Estado
    {
        public override void Acelerar()
        {
            if (this._context.CombustibleActual > 0)
            {
                // El vehiculo se pone en marcha. Aumenta la velocidad y cambiamos de estado
                //estado = EN_MARCHA;
                this._context.TransitionTo(new EnMarchaState());
                Console.WriteLine("El vehiculo se encuentra ahora EN MARCHA");
                this._context.ModificarVelocidad(10);
                this._context.ModificarCombustible(-10);
            }
            else
            {
                //estado = SIN COMBUSTIBLE
                this._context.TransitionTo(new SinCombustibleState());
                Console.WriteLine("El vehiculo se encuentra ahora SIN COMBUSTIBLE");
            }
        }

        public override void Contacto()
        {
            this._context.TransitionTo(new ApagadoState());
            Console.WriteLine("El vehiculo se encuentra ahora APAGADO");
        }

        public override void Frenar()
        {
            Console.WriteLine("ERROR: El vehiculo ya se encuentra detenido");
        }
    }
}
