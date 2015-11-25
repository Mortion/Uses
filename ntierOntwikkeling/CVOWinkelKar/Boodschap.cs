using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVOWinkelKar
{
    class Boodschap
    {
        public int ID { get; set; }
        public string Beschrijving { get; set; }
        public string Winkel { get; set; }
        public int Aantal { get; set; }

        public override string ToString()
        {
            return Aantal + "x "+ Beschrijving + "  (" + Winkel + ")";
        }
    }
}
