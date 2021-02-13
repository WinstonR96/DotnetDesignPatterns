using Observer.Exercise1.Observer;

namespace Observer.Exercise1.Subject
{
    public interface ISubject
    {
        // Adjunta un observador al sujeto.
        void Attach(IObservador observer);

        // Separar a un observador del sujeto.
        void Detach(IObservador observer);

        // Notifica a todos los observadores sobre un evento.
        void Notify();
    }
}
