using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainLibrary
{
    public class Dier : IDier
    {
        #region Properties

        public int Poten { get; set; }
        public String Naam { get; set; }
        public EDier Soort { get; set; }
        public String Geluid { get; set; }
        #endregion

        #region Constructor / Destructor

        public Dier()
        {
            this.Naam = "";
            this.Poten = AantalPoten();
            this.Geluid = MaakGeluid();
            this.Soort = TypeDier();   
        }

        ~Dier()
        {
            
        }

        #endregion


        #region IMethods
        public int AantalPoten()
        {
            return 0;
        }

        public string MaakGeluid()
        {
            return this.GetType().Name + " doet: " + Geluid;
        }

        public EDier TypeDier()
        {
            return EDier.Onbekend;
        }
        #endregion

    }
}
