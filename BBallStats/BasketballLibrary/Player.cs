using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLibrary
{
    public class Player
    {

        public String Name { get; set; }
        public int Number { get; set; }
        public List<Shot> Shots { get; set; }
        public int Fouls { get; set; }
        public List<Foul> FoulsMade { get; set; }


        public Player()
        {
            this.Name = "";
            this.Number = 0;
            this.Shots = new List<Shot>();
            this.Fouls = 0;
            this.FoulsMade = new List<Foul>();
        }

        public Player(String Name, int Number)
        {
            this.Name = Name;
            this.Number = Number;
            this.Shots = new List<Shot>();
            this.Fouls = 0;
            this.FoulsMade = new List<Foul>();
        }

        public override string ToString()
        {
            return this.Number + ". " + this.Name + " score: " + TotalScore();
        }

        public int TotalScore()
        {
            int score = 0;

            foreach (Shot s in Shots)
            {
                score += s.Point;
            }
            return score;
        }

        public String ToonFouten()
        {
            String fouten = "";
            switch (this.Fouls)
            {
                case 0:
                    fouten = "□ □ □ □ □";
                    break;
                case 1:
                    fouten = "■ □ □ □ □";
                    break;
                case 2:
                    fouten = "■ ■ □ □ □";
                    break;
                case 3:
                    fouten = "■ ■ ■ □ □";
                    break;
                case 4:
                    fouten = "■ ■ ■ ■ □";
                    break;
                case 5:
                    fouten = "■ ■ ■ ■ ■";
                    break;
            }


            return fouten;
        }

        public void ShotAdd(Shot Shot)
        {
            Shots.Add(Shot);
        }

        public void ShotRemoveLast()
        {
            Shots.RemoveAt(Shots.Count - 1);
        }

        public void AddFoul(Foul foul)
        {
            if (this.Fouls < 5)
            {
                this.Fouls++;
                this.FoulsMade.Add(foul);
            }
           


        }
        public void SubstractFoul()
        {
            if (this.Fouls > 0)
            {
                this.Fouls--;
                this.FoulsMade.RemoveAt(FoulsMade.Count - 1);
            }

        }

    }
}
