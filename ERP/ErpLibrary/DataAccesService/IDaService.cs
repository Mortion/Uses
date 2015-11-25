using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpLibrary.DataAccesService
{
    internal interface IDaService<T>
    {
        void Add(T item);
        void Delete(T item);
        T GetSelect(T item);
        List<T> GetAll();
      

    }
}
