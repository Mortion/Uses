using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballLibrary
{
    public class Team
    {
        public String Name { get; set; }
        public int countTeamFouls { get; set; }     

        public List<Player> Players { get; set; }

        public Team()
        {
            this.Name = "";
           
            this.Players = new List<Player>();
            this.countTeamFouls = 0;
        }

        public Team(String Name)
        {
            this.Name = Name;
            this.countTeamFouls = 0;
            this.Players = new List<Player>();
        }

        public override string ToString()
        {
            return  this.Name + " score: " + TotalScore();
        }

        public int TotalScore()
        {
            int score = 0;

            foreach(Player s in Players)
            {
                score += s.TotalScore();
            }
            return score;
        }

        public void PlayerAdd(Player player)
        {
            Players.Add(player);
        }

        public void PlayerRemoveLast()
        {
            Players.RemoveAt(Players.Count - 1);
        }

    }
}
