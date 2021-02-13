using Observer.Exercise1.Subject;

namespace Observer.Exercise1.Observer
{
    public interface IObservador
    {
        void Update(ISubject subject);
    }
}
