using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankrekeningLibrary
{
    /// <summary>
    ///     Gemaakt door: Jarrik Van Camp
    ///     Klas: 12675
    /// </summary>
    public class BankrekeningInHetRoodEventArgs : EventArgs
    {
        /// <summary>
        /// Percentage van het deel onder 0;
        /// </summary>
        public Double Percentage { get; set; }

        /// <summary>
        /// Zet het Percentage naar het berekend Percentage;
        /// </summary>
        /// <param name="Percentage">Saldo/MaximumInHetRood * 100</param>
        public BankrekeningInHetRoodEventArgs(Double Percentage)
        {
            this.Percentage = Percentage;
        }
    }

    /// <summary>
    ///     Gemaakt door: Jarrik Van Camp
    ///     Klas: 12675
    /// </summary>
   
}
