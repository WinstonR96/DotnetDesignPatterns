using Observer.Exercise1.Observer;
using Observer.Exercise1.Subject;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Observer.Exercise1.ConcreteSubject
{
    public class EstacionMetereologica : ISubject
    {
        public decimal Temperatura { get; set; }
        public decimal Presion { get; set; }
        public decimal Humedad { get; set; }

        private List<IObservador> _observers = new List<IObservador>();

        public void Attach(IObservador observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObservador observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Notificando a los observadores de las nuevas temperaturas");
            foreach(var observador in _observers)
            {
                observador.Update(this);
            }
        }

        public void medidasHanCambiado()
        {
            Console.WriteLine("Han cambiado las medidas");
            Temperatura = new Random().Next(0, 40);
            Presion = new Random().Next(0, 40);
            Humedad = new Random().Next(0, 40);
            Thread.Sleep(15);
            Console.WriteLine($"Los nuevos valores son: \nTemperatura: {Temperatura}\nPresion: {Presion}\nHumedad: {Humedad}");
            Notify();
        }
    }
}
