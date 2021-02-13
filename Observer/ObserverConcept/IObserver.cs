namespace Observer.ObserverConcept
{
    public interface IObserver
    {
        // Recibe actualizacion del sujero
        void Update(ISubject subject);
    }
}
