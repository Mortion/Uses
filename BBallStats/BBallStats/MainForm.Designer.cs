namespace BBallStats
{
    partial class MainForm
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
            this.btnInitPlayers = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStatHistory = new System.Windows.Forms.Button();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInitPlayers
            // 
            this.btnInitPlayers.Location = new System.Drawing.Point(12, 41);
            this.btnInitPlayers.Name = "btnInitPlayers";
            this.btnInitPlayers.Size = new System.Drawing.Size(133, 70);
            this.btnInitPlayers.TabIndex = 0;
            this.btnInitPlayers.Text = "Init Players";
            this.btnInitPlayers.UseVisualStyleBackColor = true;
            this.btnInitPlayers.Click += new System.EventHandler(this.btnInitPlayers_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(151, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStatHistory
            // 
            this.btnStatHistory.Location = new System.Drawing.Point(294, 41);
            this.btnStatHistory.Name = "btnStatHistory";
            this.btnStatHistory.Size = new System.Drawing.Size(142, 70);
            this.btnStatHistory.TabIndex = 2;
            this.btnStatHistory.Text = "Stat History";
            this.btnStatHistory.UseVisualStyleBackColor = true;
            // 
            // lstTest
            // 
            this.lstTest.BackColor = System.Drawing.SystemColors.Control;
            this.lstTest.FormattingEnabled = true;
            this.lstTest.Location = new System.Drawing.Point(12, 126);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(424, 108);
            this.lstTest.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 250);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.btnStatHistory);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnInitPlayers);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basketball Stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitPlayers;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStatHistory;
        private System.Windows.Forms.ListBox lstTest;
    }
}

