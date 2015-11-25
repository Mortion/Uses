using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLibrary
{
    public class Item : IItemManager
    {
        public String Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        private BTW btw;

        public Item()
        {

        }

        public Item(String description, decimal price, int amount, BTW btw)
        {
            this.Description = description;
            this.Price = price;
            this.Amount = amount;
            this.btw = btw;
        }

        public decimal GetPriceBeforeBTW()
        {
            return this.Price * this.Amount;
        }

        public decimal GetBTW()
        {
            int rate;
            switch (this.btw)
            {
                case BTW.UITZONDERLIJK:
                    rate = 21;
                    break;
                case BTW.TUSSENIN:
                    rate = 21;
                    break;
                default:
                    rate = 21;
                    break;
            }


            return (GetPriceBeforeBTW() / 100) * rate;
        }

        public decimal GetPriceWithBTW()
        {
            return GetPriceBeforeBTW() + GetBTW();
        }

        public override string ToString()
        {
            return this.Description +" " + this.Price +" * " + this.Amount+" = "+this.GetPriceBeforeBTW()+" + " +this.GetBTW()+" = " + this.GetPriceWithBTW();
        }

    }

    public enum BTW
    {
        STANDAARD,
        UITZONDERLIJK,
        TUSSENIN
    }
}
