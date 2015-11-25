using BasketballLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBallStats
{
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        public Team TeamHome { get; set; }
        public Team TeamAway { get; set; }
        private Team SelectedTeam = new Team();

        frmGameTime frmGametime;

        private void frmScore_Load(object sender, EventArgs e)
        {
            frmGametime = new frmGameTime();
            frmGametime.TeamHome = this.TeamHome;
            frmGametime.TeamAway = this.TeamAway;

            frmGametime.Show();

            LoadComboboxesTeams();
            LoadComboboxesPlayers();
        }
        private void LoadComboboxesTeams()
        {
            cbTeam.Items.Add(TeamHome.Name);
            cbTeam.Items.Add(TeamAway.Name);
            cbTeam.SelectedIndex = 0;

        }
        private void LoadComboboxesPlayers()
        {
            cbPlayers.Items.Clear();
            cbFouls.Items.Clear();
            if (cbTeam.SelectedIndex == 0)
            {
                SelectedTeam = TeamHome;
                foreach (Player player in TeamHome.Players)
                {
                    cbPlayers.Items.Add(player.Number + ". " + player.Name);
                    cbFouls.Items.Add(player.Number + ". " + player.Name);
                }
            }
            else
            {
                SelectedTeam = TeamAway;
                foreach (Player player in TeamAway.Players)
                {
                    cbPlayers.Items.Add(player.Number + ". " + player.Name);
                    cbFouls.Items.Add(player.Number + ". " + player.Name);
                }
            }
            cbFouls.SelectedIndex = 0;
            cbPlayers.SelectedIndex = 0;
        }

        private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboboxesPlayers();
        }

        private void btnApplyScoreChange_Click(object sender, EventArgs e)
        {
            Player player = SelectedTeam.Players[cbPlayers.SelectedIndex];

            if (rbFieldGoal.Checked == true)
            {
                if (MessageBox.Show("Scored?", "Field Goal " + player.Name, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SelectedTeam.Players[cbPlayers.SelectedIndex].ShotAdd(new Shot(2, true));
                }
                else
                {
                    SelectedTeam.Players[cbPlayers.SelectedIndex].ShotAdd(new Shot(2, false));
                }
            }
            else if (rbFreeThrow.Checked == true)
            {
                if (MessageBox.Show("Scored?", "Freethrow " + player.Name, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SelectedTeam.Players[cbPlayers.SelectedIndex].ShotAdd(new Shot(1, true));
                }
                else
                {
                    SelectedTeam.Players[cbPlayers.SelectedIndex].ShotAdd(new Shot(1, false));
                }
            }
            else
            {
                if (MessageBox.Show("Scored?", "Threepointer " + player.Name, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SelectedTeam.Players[cbPlayers.SelectedIndex].ShotAdd(new Shot(3, true));
                }
                else
                {
                    SelectedTeam.Players[cbPlayers.SelectedIndex].ShotAdd(new Shot(3, false));
                }
            }

            frmGametime.ScoreboardUpdate();

        }

        private void btnSubstractScore_Click(object sender, EventArgs e)
        {
            SelectedTeam.Players[cbPlayers.SelectedIndex].ShotRemoveLast();
            frmGametime.ScoreboardUpdate();
        }
        /// <summary>
        /// TODO: Niet boven 5 fouten
        /// </summary>
        private void btnAddFoul_Click(object sender, EventArgs e)
        {
            

            if (rbNormalFoul.Checked == true)
            {
                SelectedTeam.Players[cbFouls.SelectedIndex].AddFoul(new Foul(EFouls.Normal));

            }
            else if (rbIntentionalFoul.Checked == true)
            {
                SelectedTeam.Players[cbFouls.SelectedIndex].AddFoul(new Foul(EFouls.Intentional));
            }
            else
            {
                SelectedTeam.Players[cbFouls.SelectedIndex].AddFoul(new Foul(EFouls.Technical));
            }

            if (SelectedTeam.countTeamFouls <= 4)
            {
                SelectedTeam.countTeamFouls++;
            }
            else
            {
                MessageBox.Show("5 Ploegfouten");
            }

            frmGametime.ScoreboardUpdate();
        }

        private void btnSubstractFoul_Click(object sender, EventArgs e)
        {
           
            if (SelectedTeam.countTeamFouls >= 1)
            {
                SelectedTeam.Players[cbFouls.SelectedIndex].SubstractFoul();
                SelectedTeam.countTeamFouls--;
            }
          
            frmGametime.ScoreboardUpdate();
        }
    }
}
