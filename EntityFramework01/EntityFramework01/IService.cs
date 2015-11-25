using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework01
{
    public interface IService<T>
    {
        void Add(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetSelect(T item);
    }
}
