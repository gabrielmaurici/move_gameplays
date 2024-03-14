namespace MoveGameplays.Domain.Interfaces.Observer
{
    public interface IObservedContract<T>
    {
        void Subscribe(IObserverContract<T> observer);
        void Unsubscribe(IObserverContract<T> observer);
        void NotifiesSubscribers(T notification);
    }
}
