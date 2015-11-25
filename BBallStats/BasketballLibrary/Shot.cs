using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLibrary
{
    public class Shot
    {

        public int Point { get; set; }
        public bool IsScored { get; set; }
        public Shot()
        {
            this.Point = 0;
            this.IsScored = false;
        }

        public Shot(int Point, bool IsScored)
        {
            this.Point = Point;
            this.IsScored = IsScored;
        }

        public override string ToString()
        {
            if (IsScored == true)
            {
                return "Scored! Point(s): " + this.Point;
            }
            else { return "Miss, 0 Points"; }


        }

    }
}
