using Observer.Exercise1.ConcreteObserver;
using Observer.Exercise1.ConcreteSubject;
using Observer.ObserverConcept;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Observer Concept
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            //Exercice 1
            var estacion = new EstacionMetereologica();
            var dipositivoTemperatura = new DispositivoTiempoActual();
            estacion.Attach(dipositivoTemperatura);
            for (int i = 0; i < 10; i++)
            {
                estacion.medidasHanCambiado();
            }
            
        }
    }
}
