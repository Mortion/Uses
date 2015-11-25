using BasketballLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBallStats
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<Team> teams = new List<Team>();

        private void btnInitPlayers_Click(object sender, EventArgs e)
        {


            frmInitPlayers InitPlayers = new frmInitPlayers();

            if (InitPlayers.ShowDialog() == DialogResult.OK)
            {

                if (teams.Count == 2)
                {
                    teams.RemoveAt(1);
                    teams.Add(new Team());
                }
                else
                {
                    teams.Add(new Team());
                }

                // teams.Add(InitPlayers.TeamHome);
                teams[1] = InitPlayers.TeamAway;
                ShowTeams();
            }
        }

        private void ShowTeams()
        {
            foreach (Team team in teams)
            {
                lstTest.Items.Add(team.Name);
                lstTest.Items.Add(".......");
                foreach (Player player in team.Players)
                {
                    lstTest.Items.Add(player.ToString());
                }
            }


        }

        private string path = System.AppDomain.CurrentDomain.BaseDirectory.Substring(0, System.AppDomain.CurrentDomain.BaseDirectory.Length - 10);

        private void MainForm_Load(object sender, EventArgs e)
        {
            teams.Clear();

            //TODO
            StreamReader file = new StreamReader(path + "HomeTeam.txt");
            string lijn;
            int teller = 0; ;
            while ((lijn = file.ReadLine()) != null)
            {
                if (teller == 0)
                {
                    teams.Add(new Team(lijn));
                    teller++;
                }
                else
                {
                    string[] appart = lijn.Split('|');



                    Player pr = new Player();
                    pr.Name = appart[0];
                    pr.Number = int.Parse(appart[1]);
                    teams[0].Players.Add(pr);

                }



            }

            file.Close();

            SortPlayersTeam();
            ShowTeams();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter file = new StreamWriter(path + "HomeTeam.txt");
            file.WriteLine(teams[0].Name);
            foreach (Player pr in teams[0].Players)
            {
                file.WriteLine(pr.Name + "|" + pr.Number);
            }
            file.Close();

        }

        private void SortPlayersTeam()
        {
            Team Sorted = new Team();
            int length = teams[0].Players.Count;


            while (length >= 0)
            {
                int min = 100;
                for (int i = 0; i < teams[0].Players.Count; i++)
                {
                    if (teams[0].Players[i].Number < min)
                    {
                        min = teams[0].Players[i].Number;
                    }
                }

                for (int i = 0; i < teams[0].Players.Count; i++)
                {
                    if (teams[0].Players[i].Number == min)
                    {
                        Sorted.Players.Add(teams[0].Players[i]);
                        teams[0].Players.RemoveAt(i);
                        break;
                    }
                }

                length--;
            }

            foreach (Player p in Sorted.Players)
            {
                teams[0].Players.Add(p);
            }
        }
        private frmGameTime frmGametime;
        public frmScore frmScore;
        private void btnStart_Click(object sender, EventArgs e)
        {
          

            frmScore = new frmScore();
            frmScore.TeamHome = teams[0];
            frmScore.TeamAway = teams[1];

            frmScore.Show();
            
        }
    }
}
