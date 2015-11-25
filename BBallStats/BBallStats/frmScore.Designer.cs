namespace BBallStats
{
    partial class frmScore
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFouls = new System.Windows.Forms.ComboBox();
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.btnApplyScoreChange = new System.Windows.Forms.Button();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.rbFreeThrow = new System.Windows.Forms.RadioButton();
            this.rbFieldGoal = new System.Windows.Forms.RadioButton();
            this.btnSubstractScore = new System.Windows.Forms.Button();
            this.btnSubstractFoul = new System.Windows.Forms.Button();
            this.btnAddFoul = new System.Windows.Forms.Button();
            this.rbThreePointer = new System.Windows.Forms.RadioButton();
            this.rbTechnicalFoul = new System.Windows.Forms.RadioButton();
            this.rbIntentionalFoul = new System.Windows.Forms.RadioButton();
            this.rbNormalFoul = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fouls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Score";
            // 
            // cbFouls
            // 
            this.cbFouls.FormattingEnabled = true;
            this.cbFouls.Location = new System.Drawing.Point(49, 66);
            this.cbFouls.Name = "cbFouls";
            this.cbFouls.Size = new System.Drawing.Size(131, 21);
            this.cbFouls.TabIndex = 20;
            // 
            // cbPlayers
            // 
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Location = new System.Drawing.Point(49, 39);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(131, 21);
            this.cbPlayers.TabIndex = 19;
            // 
            // btnApplyScoreChange
            // 
            this.btnApplyScoreChange.Location = new System.Drawing.Point(326, 37);
            this.btnApplyScoreChange.Name = "btnApplyScoreChange";
            this.btnApplyScoreChange.Size = new System.Drawing.Size(47, 23);
            this.btnApplyScoreChange.TabIndex = 23;
            this.btnApplyScoreChange.Text = "Add";
            this.btnApplyScoreChange.UseVisualStyleBackColor = true;
            this.btnApplyScoreChange.Click += new System.EventHandler(this.btnApplyScoreChange_Click);
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(49, 12);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(131, 21);
            this.cbTeam.TabIndex = 24;
            this.cbTeam.SelectedIndexChanged += new System.EventHandler(this.cbTeam_SelectedIndexChanged);
            // 
            // rbFreeThrow
            // 
            this.rbFreeThrow.AutoSize = true;
            this.rbFreeThrow.Checked = true;
            this.rbFreeThrow.Location = new System.Drawing.Point(186, 43);
            this.rbFreeThrow.Name = "rbFreeThrow";
            this.rbFreeThrow.Size = new System.Drawing.Size(38, 17);
            this.rbFreeThrow.TabIndex = 25;
            this.rbFreeThrow.TabStop = true;
            this.rbFreeThrow.Text = "FT";
            this.rbFreeThrow.UseVisualStyleBackColor = true;
            // 
            // rbFieldGoal
            // 
            this.rbFieldGoal.AutoSize = true;
            this.rbFieldGoal.Location = new System.Drawing.Point(230, 42);
            this.rbFieldGoal.Name = "rbFieldGoal";
            this.rbFieldGoal.Size = new System.Drawing.Size(39, 17);
            this.rbFieldGoal.TabIndex = 26;
            this.rbFieldGoal.Text = "FG";
            this.rbFieldGoal.UseVisualStyleBackColor = true;
            // 
            // btnSubstractScore
            // 
            this.btnSubstractScore.Location = new System.Drawing.Point(379, 37);
            this.btnSubstractScore.Name = "btnSubstractScore";
            this.btnSubstractScore.Size = new System.Drawing.Size(42, 23);
            this.btnSubstractScore.TabIndex = 27;
            this.btnSubstractScore.Text = "Substract";
            this.btnSubstractScore.UseVisualStyleBackColor = true;
            this.btnSubstractScore.Click += new System.EventHandler(this.btnSubstractScore_Click);
            // 
            // btnSubstractFoul
            // 
            this.btnSubstractFoul.Location = new System.Drawing.Point(379, 64);
            this.btnSubstractFoul.Name = "btnSubstractFoul";
            this.btnSubstractFoul.Size = new System.Drawing.Size(42, 23);
            this.btnSubstractFoul.TabIndex = 29;
            this.btnSubstractFoul.Text = "Substract";
            this.btnSubstractFoul.UseVisualStyleBackColor = true;
            this.btnSubstractFoul.Click += new System.EventHandler(this.btnSubstractFoul_Click);
            // 
            // btnAddFoul
            // 
            this.btnAddFoul.Location = new System.Drawing.Point(326, 64);
            this.btnAddFoul.Name = "btnAddFoul";
            this.btnAddFoul.Size = new System.Drawing.Size(47, 23);
            this.btnAddFoul.TabIndex = 28;
            this.btnAddFoul.Text = "Add";
            this.btnAddFoul.UseVisualStyleBackColor = true;
            this.btnAddFoul.Click += new System.EventHandler(this.btnAddFoul_Click);
            // 
            // rbThreePointer
            // 
            this.rbThreePointer.AutoSize = true;
            this.rbThreePointer.Location = new System.Drawing.Point(275, 42);
            this.rbThreePointer.Name = "rbThreePointer";
            this.rbThreePointer.Size = new System.Drawing.Size(45, 17);
            this.rbThreePointer.TabIndex = 30;
            this.rbThreePointer.Text = "3PT";
            this.rbThreePointer.UseVisualStyleBackColor = true;
            // 
            // rbTechnicalFoul
            // 
            this.rbTechnicalFoul.AutoSize = true;
            this.rbTechnicalFoul.Location = new System.Drawing.Point(275, 67);
            this.rbTechnicalFoul.Name = "rbTechnicalFoul";
            this.rbTechnicalFoul.Size = new System.Drawing.Size(38, 17);
            this.rbTechnicalFoul.TabIndex = 33;
            this.rbTechnicalFoul.Text = "TF";
            this.rbTechnicalFoul.UseVisualStyleBackColor = true;
            // 
            // rbIntentionalFoul
            // 
            this.rbIntentionalFoul.AutoSize = true;
            this.rbIntentionalFoul.Location = new System.Drawing.Point(230, 67);
            this.rbIntentionalFoul.Name = "rbIntentionalFoul";
            this.rbIntentionalFoul.Size = new System.Drawing.Size(34, 17);
            this.rbIntentionalFoul.TabIndex = 32;
            this.rbIntentionalFoul.Text = "IF";
            this.rbIntentionalFoul.UseVisualStyleBackColor = true;
            // 
            // rbNormalFoul
            // 
            this.rbNormalFoul.AutoSize = true;
            this.rbNormalFoul.Checked = true;
            this.rbNormalFoul.Location = new System.Drawing.Point(186, 67);
            this.rbNormalFoul.Name = "rbNormalFoul";
            this.rbNormalFoul.Size = new System.Drawing.Size(31, 17);
            this.rbNormalFoul.TabIndex = 31;
            this.rbNormalFoul.TabStop = true;
            this.rbNormalFoul.Text = "F";
            this.rbNormalFoul.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "FT= Freethrow, FG = Fieldgoal, 3PT = Threepointer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "F = Normal Foul, IF = Intentional Foul, TF = Technical Foul";
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 304);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbTechnicalFoul);
            this.Controls.Add(this.rbIntentionalFoul);
            this.Controls.Add(this.rbNormalFoul);
            this.Controls.Add(this.rbThreePointer);
            this.Controls.Add(this.btnSubstractFoul);
            this.Controls.Add(this.btnAddFoul);
            this.Controls.Add(this.btnSubstractScore);
            this.Controls.Add(this.rbFieldGoal);
            this.Controls.Add(this.rbFreeThrow);
            this.Controls.Add(this.cbTeam);
            this.Controls.Add(this.btnApplyScoreChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFouls);
            this.Controls.Add(this.cbPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats Changer";
            this.Load += new System.EventHandler(this.frmScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFouls;
        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.Button btnApplyScoreChange;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.RadioButton rbFreeThrow;
        private System.Windows.Forms.RadioButton rbFieldGoal;
        private System.Windows.Forms.Button btnSubstractScore;
        private System.Windows.Forms.Button btnSubstractFoul;
        private System.Windows.Forms.Button btnAddFoul;
        private System.Windows.Forms.RadioButton rbThreePointer;
        private System.Windows.Forms.RadioButton rbTechnicalFoul;
        private System.Windows.Forms.RadioButton rbIntentionalFoul;
        private System.Windows.Forms.RadioButton rbNormalFoul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}