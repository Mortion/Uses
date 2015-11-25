using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLibrary
{
    public interface IItemManager
    {
        decimal GetPriceBeforeBTW();
        decimal GetBTW();
        decimal GetPriceWithBTW();


    }
}
