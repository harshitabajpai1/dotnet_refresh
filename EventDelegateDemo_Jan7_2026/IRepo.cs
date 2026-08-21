namespace EventDelegateDemo
{
    public interface IRepo<T>
    {
        T SearchById(int id);
        bool Add(T item);
    }
}