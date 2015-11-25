using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOWinkelKar
{
    class WinkelService
    {
        DaBoodschapParameters da = new DaBoodschapParameters();

        public void BoodschapToevoegen(Boodschap boodschap)
        {
            da.Toevoegen(boodschap);
        }

        public void BoodschapVerwijderen(Boodschap b)
        {
            BoodschapVerwijderen(b.ID);
        }

        public void BoodschapVerwijderen(int id)
        {
            da.Verwijderen(id);
        }

        public List<Boodschap> AlleBoodschappenOpvragen()
        {
            return da.GetAllBoodschappen();
        }



    }
}
