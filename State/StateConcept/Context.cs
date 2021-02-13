using System;

namespace State.StateConcept
{
    //El contexto define la interfaz de interés para los clientes. También mantiene una 
    //referencia a una instancia de una subclase de estado, que representa el estado actual del contexto.
    public class Context
    {
        // Una referencia al estado actual del contexto
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        // El contexto permite cambiar el objeto de estado en tiempo de ejecución.
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        //El contexto delega parte de su comportamiento al objeto de estado actual.
        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
