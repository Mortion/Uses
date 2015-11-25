using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLibrary
{
   public class Foul
    {

      
        public EFouls FoulType { get; set; }


        public Foul()
        {
           
            this.FoulType = EFouls.Normal;
        }
        public Foul( EFouls FoulType)
        {
           
            this.FoulType = FoulType;
        }

    }


   
}
