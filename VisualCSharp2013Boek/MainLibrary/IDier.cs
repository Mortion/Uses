using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainLibrary
{
    interface IDier
    {
        string MaakGeluid();
        int AantalPoten();
        EDier TypeDier();
    }
}
