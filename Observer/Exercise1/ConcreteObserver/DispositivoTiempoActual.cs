using Observer.Exercise1.ConcreteSubject;
using Observer.Exercise1.Observer;
using Observer.Exercise1.Subject;
using System;

namespace Observer.Exercise1.ConcreteObserver
{
    public class DispositivoTiempoActual : IObservador
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Dispositivo de clima  es notificado del cambio de temperatura");
            var result = subject as EstacionMetereologica;
            var temperatura = result.Temperatura;
            if(temperatura <= 5)
            {
                Console.WriteLine("Nevada, no salir de casa");
            }
            if(temperatura > 5 && temperatura <= 15)
            {
                Console.WriteLine("Lluvias contastes");
            }
            if (temperatura > 15 && temperatura <= 26)
            {
                Console.WriteLine("Lluvias moderadas");
            }
            if (temperatura > 26)
            {
                Console.WriteLine("Soleada");
            }
        }
    }
}
