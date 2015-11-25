using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankrekeningLibrary
{
    public class BankrekeningOverHetRoodEventArgs : EventArgs
    {

        /// <summary>
        /// Zet het Percentage naar het berekend Percentage;
        /// </summary>
        /// <param name="Percentage">Saldo/MaximumInHetRood * 100</param>
        public BankrekeningOverHetRoodEventArgs()
        {
        
        }
    }
}
