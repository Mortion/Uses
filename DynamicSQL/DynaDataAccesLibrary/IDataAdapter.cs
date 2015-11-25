using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaDataAccesLibrary
{
  public interface IDataAdapter<T>
    {

        List<T> GetAll();
        T GetSingle(T item);
        void Delete(T item);
        void Update(T item);
        void AddSingle(T item);
        void AddAll(List<T> items);
        

    }
}
