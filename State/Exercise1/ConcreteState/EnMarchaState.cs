using State.Exercise1.State;
using System;


namespace State.Exercise1.ConcreteState
{
    public class EnMarchaState : Estado
    {
        private const int VELOCIDAD_MAXIMA = 200;
        public override void Acelerar()
        {
            if (this._context.CombustibleActual > 0)
            {
                // Aumentamos la velocidad, permaneciendo en el mismo estado
                if (this._context.VelocidadActual >= VELOCIDAD_MAXIMA)
                {
                    Console.WriteLine("ERROR: El coche ha alcanzado su velocidad maxima");
                    this._context.ModificarCombustible(-10);
                }
                else
                {
                    this._context.ModificarVelocidad(10);
                    this._context.ModificarCombustible(-10);
                }
            }
            else
            {
                //estado = SIN COMBUSTIBLE
                this._context.TransitionTo(new SinCombustibleState());
                Console.WriteLine("El vehiculo se ha quedado sin combustible");
            }
        }

        public override void Contacto()
        {
            Console.WriteLine("ERROR: No se puede cortar el contacto en marcha!");
        }

        public override void Frenar()
        {
            // Reducimos la velocidad. Si esta llega a 0, cambiaremos a estado "PARADO"
            this._context.ModificarVelocidad(-10);
            if (this._context.VelocidadActual <= 0)
            {
                //estado = PARADO;
                this._context.TransitionTo(new ParadoState());  
                Console.WriteLine("El vehiculo se encuentra ahora PARADO");
            }
        }
    }
}
