using State.Exercise1.State;
using System;

namespace State.Exercise1.Context
{
    public class Vehiculo
    {
        // Una referencia al estado actual del contexto
        private Estado _state = null;
        private int velocidadActual = 0;      // Velocidad actual del vehiculo
        private int combustibleActual = 0;    // Cantidad de combustible restante

        public Vehiculo(int combustible, Estado state)
        {
            this.combustibleActual = combustible;
            this.TransitionTo(state);
        }

        // Asigna o recupera el estado del vehiculo
        public Estado Estado
        {
            get { return _state; }
            set { _state = value; }
        }

        // Asigna o recupera la velocidad actual del vehiculo
        public int VelocidadActual
        {
            get { return velocidadActual; }
            set { velocidadActual = value; }
        }

        // Obtiene la cantidad de combustible actual
        public int CombustibleActual
        {
            get { return combustibleActual; }
        }

        // El contexto permite cambiar el objeto de estado en tiempo de ejecución.
        public void TransitionTo(Estado state)
        {
            Console.WriteLine($"Vehiculo: Cambio de estado a: {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        // Los metodos del contexto invocaran el metodo de la interfaz State, delegando las operaciones
        // dependientes del estado en las clases que los implementen.
        public void Acelerar()
        {
            _state.Acelerar();
            Console.WriteLine("Velocidad actual: " + velocidadActual + ". Combustible restante: " + combustibleActual);
        }

        public void Frenar()
        {
            _state.Frenar();
        }

        public void Contacto()
        {
            _state.Contacto();
        }

        public void ModificarVelocidad(int kmh)
        {
            velocidadActual += kmh;
        }

        public void ModificarCombustible(int decilitros)
        {
            combustibleActual += decilitros;
        }
    }
}
