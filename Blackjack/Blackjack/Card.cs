using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {

        public int Value { get; set; }
        public CardID Name { get; set; }
        public bool IsPicture { get; set; }
        public int SecondValue { get; set; }


        public Card()
        {
            this.Value = 0;
            this.Name = CardID.unknown;
            this.IsPicture = false;
            this.SecondValue = 0;
        }

        public Card(int Value, CardID Name)
        {
            this.Value = Value;
            this.Name = Name;
            this.IsPicture = false;
            this.SecondValue = 0;
        }
        public Card(int Value, CardID Name,bool IsPicture)
        {
            this.Value = Value;
            this.Name = Name;
            this.IsPicture = IsPicture;
           
        }
       

      
        }

    }

    public enum CardID
    {
        unknown =-1,
        one ,
        two = 2,
        three = 3,
        four = 4,
        five =5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9,
        ten = 10,
        jack = 10,
        queen = 10,
        king = 10

    }
}
