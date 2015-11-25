namespace BankjeSpelen
{
    partial class frmMain
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblDieptepunt = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtDieptepunt = new System.Windows.Forms.TextBox();
            this.btnRekeningAanmaken = new System.Windows.Forms.Button();
            this.grpOverschrijvingen = new System.Windows.Forms.GroupBox();
            this.lblOverschrijving = new System.Windows.Forms.Label();
            this.txtOverschrijving = new System.Windows.Forms.TextBox();
            this.btnOverschrijving = new System.Windows.Forms.Button();
            this.grpOverschrijvingen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 9);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblDieptepunt
            // 
            this.lblDieptepunt.AutoSize = true;
            this.lblDieptepunt.Location = new System.Drawing.Point(12, 33);
            this.lblDieptepunt.Name = "lblDieptepunt";
            this.lblDieptepunt.Size = new System.Drawing.Size(59, 13);
            this.lblDieptepunt.TabIndex = 1;
            this.lblDieptepunt.Text = "Dieptepunt";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(78, 6);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(106, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // txtDieptepunt
            // 
            this.txtDieptepunt.Location = new System.Drawing.Point(78, 30);
            this.txtDieptepunt.Name = "txtDieptepunt";
            this.txtDieptepunt.Size = new System.Drawing.Size(106, 20);
            this.txtDieptepunt.TabIndex = 3;
            // 
            // btnRekeningAanmaken
            // 
            this.btnRekeningAanmaken.Location = new System.Drawing.Point(360, 4);
            this.btnRekeningAanmaken.Name = "btnRekeningAanmaken";
            this.btnRekeningAanmaken.Size = new System.Drawing.Size(134, 23);
            this.btnRekeningAanmaken.TabIndex = 4;
            this.btnRekeningAanmaken.Text = "Rekening aanmaken";
            this.btnRekeningAanmaken.UseVisualStyleBackColor = true;
            this.btnRekeningAanmaken.Click += new System.EventHandler(this.btnRekeningAanmaken_Click);
            // 
            // grpOverschrijvingen
            // 
            this.grpOverschrijvingen.Controls.Add(this.btnOverschrijving);
            this.grpOverschrijvingen.Controls.Add(this.txtOverschrijving);
            this.grpOverschrijvingen.Controls.Add(this.lblOverschrijving);
            this.grpOverschrijvingen.Enabled = false;
            this.grpOverschrijvingen.Location = new System.Drawing.Point(15, 56);
            this.grpOverschrijvingen.Name = "grpOverschrijvingen";
            this.grpOverschrijvingen.Size = new System.Drawing.Size(479, 100);
            this.grpOverschrijvingen.TabIndex = 5;
            this.grpOverschrijvingen.TabStop = false;
            this.grpOverschrijvingen.Text = "Overschrijvingen";
            // 
            // lblOverschrijving
            // 
            this.lblOverschrijving.AutoSize = true;
            this.lblOverschrijving.Location = new System.Drawing.Point(6, 45);
            this.lblOverschrijving.Name = "lblOverschrijving";
            this.lblOverschrijving.Size = new System.Drawing.Size(74, 13);
            this.lblOverschrijving.TabIndex = 0;
            this.lblOverschrijving.Text = "Overschrijving";
            // 
            // txtOverschrijving
            // 
            this.txtOverschrijving.Location = new System.Drawing.Point(100, 45);
            this.txtOverschrijving.Name = "txtOverschrijving";
            this.txtOverschrijving.Size = new System.Drawing.Size(145, 20);
            this.txtOverschrijving.TabIndex = 6;
            // 
            // btnOverschrijving
            // 
            this.btnOverschrijving.Location = new System.Drawing.Point(327, 43);
            this.btnOverschrijving.Name = "btnOverschrijving";
            this.btnOverschrijving.Size = new System.Drawing.Size(134, 23);
            this.btnOverschrijving.TabIndex = 6;
            this.btnOverschrijving.Text = "Overschrijven";
            this.btnOverschrijving.UseVisualStyleBackColor = true;
            this.btnOverschrijving.Click += new System.EventHandler(this.btnOverschrijving_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 166);
            this.Controls.Add(this.grpOverschrijvingen);
            this.Controls.Add(this.btnRekeningAanmaken);
            this.Controls.Add(this.txtDieptepunt);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblDieptepunt);
            this.Controls.Add(this.lblSaldo);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankje spelen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grpOverschrijvingen.ResumeLayout(false);
            this.grpOverschrijvingen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblDieptepunt;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtDieptepunt;
        private System.Windows.Forms.Button btnRekeningAanmaken;
        private System.Windows.Forms.GroupBox grpOverschrijvingen;
        private System.Windows.Forms.Button btnOverschrijving;
        private System.Windows.Forms.TextBox txtOverschrijving;
        private System.Windows.Forms.Label lblOverschrijving;
    }
}

