using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework01
{
    public class Service : IService<Properties>
    {
        public void Add(Properties item)
        {
            using (var context = new Context())
            {
                context.props.Add(item);
                context.SaveChanges();
            }
        }

        public void Delete(Properties item)
        {
            using (var context = new Context())
            {
                context.props.Remove(item);
                context.SaveChanges();
            }
        }

        public List<Properties> GetAll()
        {
            using (var context = new Context())
            {
                return context.props.ToList();
            }
        }

        public Properties GetSelect(Properties item)
        {
            throw new NotImplementedException();
        }
    }
}
