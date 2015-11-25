using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Library
using BasketballLibrary;

namespace BBallStats
{
    public partial class frmGameTime : Form
    {
        public frmGameTime()
        {
            InitializeComponent();
        }

        public Team TeamHome { get; set; }
        public Team TeamAway { get; set; }

        private void frmGameTime_Load(object sender, EventArgs e)
        {
            LoadTeams();
            ScoreboardUpdate();
        }

        private void LoadTeams()
        {
            lblAwayTName.Text = TeamAway.Name;
            lblHomeTName.Text = TeamHome.Name;
            
        }

        public void ScoreboardUpdate()
        {
            lstHomeName.Items.Clear();
            lstHomeNr.Items.Clear();
            lstHomePoints.Items.Clear();
            lstHomeFouls.Items.Clear();

            lstAwayName.Items.Clear();
            lstAwayNr.Items.Clear();
            lstAwayPoints.Items.Clear();
            lstAwayFouls.Items.Clear();

            lblAwayTScore.Text = TeamAway.TotalScore()+"";
            lblHomeTScore.Text = TeamHome.TotalScore() + "";

            foreach (Player player in TeamHome.Players)
            {
                lstHomeName.Items.Add(player.Name);
                lstHomeNr.Items.Add(player.Number);
                lstHomePoints.Items.Add(player.TotalScore());
                lstHomeFouls.Items.Add(player.ToonFouten());
            }
            foreach (Player player in TeamAway.Players)
            {
                lstAwayName.Items.Add(player.Name);
                lstAwayNr.Items.Add(player.Number);
                lstAwayPoints.Items.Add(player.TotalScore());
                lstAwayFouls.Items.Add(player.ToonFouten());
            }

            lblTeamFoulsHome.Text = TeamHome.countTeamFouls.ToString();
            lblTeamFoulsAway.Text = TeamAway.countTeamFouls.ToString();
        }

        private void frmGameTime_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
