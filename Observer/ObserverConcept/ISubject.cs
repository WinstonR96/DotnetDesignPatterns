namespace Observer.ObserverConcept
{
    public interface ISubject
    {
        // Adjunta un observador al sujeto.
        void Attach(IObserver observer);

        // Separar a un observador del sujeto.
        void Detach(IObserver observer);

        // Notifica a todos los observadores sobre un evento.
        void Notify();
    }
}
