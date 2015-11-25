using System.Collections.Generic;

namespace voorbeeldGebruikInterfaces
{
    interface IPersistance <T>
    {
        void Delete(int id);
        T Get(int id);
        List<T> GetAll();
        void Save(T b);
    }
}
