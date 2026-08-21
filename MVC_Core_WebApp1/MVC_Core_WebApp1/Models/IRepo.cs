namespace MVC_Core_WebApp1.Models
{
    public interface IRepo<T>   //for repository pattern, to decouple the data access logic from the business logic and presentation layer, making the application more modular and easier to maintain.
    {
        //generic interface to perform CRUD operations on any type of entity, such as Student, Course, etc.

        bool AddData(T obj);
        //to add a new entity to the data store, returns true if the operation is successful, false otherwise.
        bool UpdateData(int id,T obj);
        bool DeleteData(int id);
        List<T> ShowAllData();
        T ShowDetailsById(int id);
    }
}
