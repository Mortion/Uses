using System;
using System.Collections.Generic;

namespace voorbeeldGebruikInterfaces
{
    interface IPersistance <T>
    {
        void Delete(int id);
        T Get();
        List<T> GetAll();
        void Save(T b);
    }
}
