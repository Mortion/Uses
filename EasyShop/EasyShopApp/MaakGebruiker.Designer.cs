namespace EasyShopApp
{
    partial class frmMaakGebruiker
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnGebruikerToevoegen = new System.Windows.Forms.Button();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtPasswoord = new System.Windows.Forms.TextBox();
            this.txtPaswoordherhaling = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwoord";
            // 
            // btnGebruikerToevoegen
            // 
            this.btnGebruikerToevoegen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGebruikerToevoegen.Location = new System.Drawing.Point(12, 124);
            this.btnGebruikerToevoegen.Name = "btnGebruikerToevoegen";
            this.btnGebruikerToevoegen.Size = new System.Drawing.Size(308, 23);
            this.btnGebruikerToevoegen.TabIndex = 2;
            this.btnGebruikerToevoegen.Text = "Toevoegen";
            this.btnGebruikerToevoegen.UseVisualStyleBackColor = true;
            this.btnGebruikerToevoegen.Click += new System.EventHandler(this.btnGebruikerToevoegen_Click);
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.Location = new System.Drawing.Point(125, 17);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(198, 20);
            this.txtGebruikersnaam.TabIndex = 3;
            // 
            // txtPasswoord
            // 
            this.txtPasswoord.Location = new System.Drawing.Point(125, 49);
            this.txtPasswoord.Name = "txtPasswoord";
            this.txtPasswoord.Size = new System.Drawing.Size(198, 20);
            this.txtPasswoord.TabIndex = 4;
            // 
            // txtPaswoordherhaling
            // 
            this.txtPaswoordherhaling.Location = new System.Drawing.Point(125, 86);
            this.txtPaswoordherhaling.Name = "txtPaswoordherhaling";
            this.txtPaswoordherhaling.Size = new System.Drawing.Size(198, 20);
            this.txtPaswoordherhaling.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Herhaal Passwoord";
            // 
            // frmMaakGebruiker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 159);
            this.Controls.Add(this.txtPaswoordherhaling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasswoord);
            this.Controls.Add(this.txtGebruikersnaam);
            this.Controls.Add(this.btnGebruikerToevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMaakGebruiker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaakGebruiker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGebruikerToevoegen;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtPasswoord;
        private System.Windows.Forms.TextBox txtPaswoordherhaling;
        private System.Windows.Forms.Label label3;
    }
}