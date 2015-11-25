using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voorbeeldGebruikInterfaces
{
    class DaBoek : voorbeeldGebruikInterfaces.IPersistance <Boek>
    {
        public void Save(Boek b)
        {

        }

        public void Delete(int id)
        {

        }

        public List<Boek> GetAll()
        {
            return null;
        }

        public Boek Get()
        {
            return null;
        }


    }
}
