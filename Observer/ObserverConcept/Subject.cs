using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer.ObserverConcept
{
    //El Sujeto posee un estado importante y notifica a los observadores cuando cambia el estado.
    public class Subject : ISubject
    {
        //En aras de la simplicidad, el estado del Sujeto, esencial para todos los suscriptores, 
        //se almacena en esta variable.
        public int state { get; set; } = -0;

        //Lista de suscriptores. En la vida real, 
        //la lista de suscriptores se puede almacenar de manera más completa (categorizada por tipo de evento, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        // Los métodos de gestión de suscripciones.
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        //Por lo general, la lógica de suscripción es solo una fracción de lo que 
        //realmente puede hacer un sujeto. Los sujetos suelen tener una lógica empresarial importante, 
        //que activa un método de notificación cada vez que algo importante está a punto de suceder (o después).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.state = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.state);
            this.Notify();
        }
    }
}
