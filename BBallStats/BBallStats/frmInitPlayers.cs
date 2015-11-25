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
    public partial class frmInitPlayers : Form
    {
        public frmInitPlayers()
        {
            InitializeComponent();
            TeamAway = new Team();
        }

      
        public Team TeamAway { get; set; }

        int TeamCount = 0;

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
           
                TeamAway = new Team(txtTeamName.Text);

                TeamCount++;
               
                txtPlayerName.Enabled = true;
              
                btnAddPlayer.Enabled = true;
                txtTeamName.Text = "";
                MessageBox.Show("Added: " + TeamAway.Name);
                AddPlayers();
            
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
           
           
                TeamAway.PlayerAdd(new Player(txtPlayerName.Text, (int)nmPlayerNumber.Value));
          
            AddPlayers();
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
           
                TeamAway.PlayerRemoveLast();
          
            AddPlayers();

        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }

      

        private void AddPlayers()
        {
            lstPlayersAway.Items.Clear();
         

         
            lstPlayersAway.Items.Add(TeamAway.Name + " " + TeamAway.Players.Count + " Players.");
            lstPlayersAway.Items.Add("____________");

            
            foreach (Player player in TeamAway.Players)
            {
                lstPlayersAway.Items.Add(player.ToString());
            }
        }
    }
}
