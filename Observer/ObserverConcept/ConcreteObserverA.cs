using System;

namespace Observer.ObserverConcept
{
    //Los Observadores concretos reaccionan a las actualizaciones emitidas por el Sujeto al que habían sido adjuntos.
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).state < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
