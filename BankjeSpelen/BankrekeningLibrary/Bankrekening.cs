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
    public class Bankrekening
    {


        #region Properties
        /// <summary>
        /// Het aantal onder 0 dat je mag overschrijden;
        /// </summary>
        public int MaximaalInHetRood { get; set; }

        /// <summary>
        /// Het totaalbedrag op je rekening
        /// </summary>
        public Double Saldo { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor met initialisatie van de properties op 0;
        /// </summary>
        public Bankrekening()
        {
            this.MaximaalInHetRood = 0;
            this.Saldo = 0;
        }

        /// <summary>
        /// Zet bankrekening op de ingegeven waardes (saldo en maximum onder 0);
        /// </summary>
        /// <param name="MaximaalInHetRood">De waarde onder 0</param>
        /// <param name="Saldo">Het totale aantal op je bankrekening</param>
        public Bankrekening(int MaximaalInHetRood, Double Saldo)
        {
            this.MaximaalInHetRood = MaximaalInHetRood;
            this.Saldo = Saldo;
        }
        #endregion

        #region Events
        /// <summary>
        /// Event dat aangeeft wanneer je in het rood staat
        ///         ( Overschrijving > Saldo + MaximumInHetRood); 
        /// </summary>
        public event EventHandler<BankrekeningInHetRoodEventArgs> BankrekeningInHetRood;
        public event EventHandler<BankrekeningOverHetRoodEventArgs> BankrekeningOverHetRood;

        #endregion

        #region EventHandlers

        /// <summary>
        /// Voert controle uit naar de BankrekeningInHetRoodEventArgs;
        /// Voert daarna de overschijving uit;
        /// </summary>
        /// <param name="Overschrijving">Het bedrag dat moet overgeschreven worden</param>
        protected void RaiseBankrekeningInEnOverHetRood(Double Overschrijving)
        {
            if (BankrekeningInHetRood != null)
            {

                if ((this.Saldo) < Overschrijving)
                {

                    if ((this.Saldo + this.MaximaalInHetRood) < Overschrijving)
                    {
                        BankrekeningOverHetRood(this, new BankrekeningOverHetRoodEventArgs());

                    }
                    else
                    {
                        this.Saldo -= Overschrijving;
                        BankrekeningInHetRood(this, new BankrekeningInHetRoodEventArgs(BerekenInHetRoodPercentage()));
                    }

                }
                else
                {
                    this.Saldo -= Overschrijving;
                }

            }
        }
        #endregion

        #region Methodes

        /// <summary>
        /// Berekend het percentage in het rood;
        /// Dit wordt alleen aangeroepen als het Saldo werkelijk onder  wil gaan
        /// (Wanneer de methode "BankrekeningInHetRood" wordt aangeroepen;
        /// </summary>
        /// <returns></returns>
        private double BerekenInHetRoodPercentage()
        {
            return (Math.Abs(this.Saldo) / MaximaalInHetRood);//* 100
        }

        /// <summary>
        /// Voert controle uit naar de BankrekeningInHetRoodEventArgs;
        /// Voert daarna de overschijving uit;
        /// </summary>
        /// <param name="Overschrijving">Het bedrag dat moet overgeschreven worden</param>
        public void Overschrijving(Double Overschrijving)
        {
            RaiseBankrekeningInEnOverHetRood(Overschrijving);
        }


        #endregion


    }


}

