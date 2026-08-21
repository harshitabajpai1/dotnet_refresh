using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconnectedArchDemo
{
    //generic interface for CRUD operations
    public interface IRepo<T>
    {
        bool AddData(T obj);
        bool UpdateData(int Id, T obj);
        bool DeleteData(int Id);
        List<T> ShowAllData();
        T SearchById(int Id);

    }
}
