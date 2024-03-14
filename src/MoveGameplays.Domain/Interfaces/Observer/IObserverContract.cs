namespace MoveGameplays.Domain.Interfaces.Observer
{
    public interface IObserverContract<T>
    {
        void Notify(T notification);
    }
}