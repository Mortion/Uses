namespace BBallStats
{
    partial class frmInitPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lstPlayersAway = new System.Windows.Forms.ListBox();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.nmPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.Location = new System.Drawing.Point(53, 63);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(141, 20);
            this.txtPlayerName.TabIndex = 2;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(53, 22);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(280, 20);
            this.txtTeamName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Team";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(353, 20);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(61, 22);
            this.btnAddTeam.TabIndex = 6;
            this.btnAddTeam.Text = "Ok";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Enabled = false;
            this.btnAddPlayer.Location = new System.Drawing.Point(353, 60);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(61, 22);
            this.btnAddPlayer.TabIndex = 7;
            this.btnAddPlayer.Text = "Ok";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(12, 230);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(402, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done.";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lstPlayersAway
            // 
            this.lstPlayersAway.FormattingEnabled = true;
            this.lstPlayersAway.Location = new System.Drawing.Point(15, 110);
            this.lstPlayersAway.Name = "lstPlayersAway";
            this.lstPlayersAway.Size = new System.Drawing.Size(399, 82);
            this.lstPlayersAway.TabIndex = 9;
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(12, 198);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(290, 26);
            this.btnRemovePlayer.TabIndex = 10;
            this.btnRemovePlayer.Text = "Remove Last";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // nmPlayerNumber
            // 
            this.nmPlayerNumber.Location = new System.Drawing.Point(227, 63);
            this.nmPlayerNumber.Name = "nmPlayerNumber";
            this.nmPlayerNumber.Size = new System.Drawing.Size(106, 20);
            this.nmPlayerNumber.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nr";
            // 
            // frmInitPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 263);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmPlayerNumber);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.lstPlayersAway);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label1);
            this.Name = "frmInitPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInitPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lstPlayersAway;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.NumericUpDown nmPlayerNumber;
        private System.Windows.Forms.Label label3;
    }
}