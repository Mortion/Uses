namespace Beertjeswinkel
{
    partial class frmBeertjeswinkel
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
            this.lstBeertjes = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.picBeertjesportret = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBeertjesportret)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBeertjes
            // 
            this.lstBeertjes.FormattingEnabled = true;
            this.lstBeertjes.Location = new System.Drawing.Point(12, 12);
            this.lstBeertjes.Name = "lstBeertjes";
            this.lstBeertjes.Size = new System.Drawing.Size(314, 238);
            this.lstBeertjes.TabIndex = 0;
            this.lstBeertjes.SelectedIndexChanged += new System.EventHandler(this.lstBeertjes_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(391, 12);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(192, 23);
            this.btnToevoegen.TabIndex = 1;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.Location = new System.Drawing.Point(391, 41);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(192, 23);
            this.btnWijzigen.TabIndex = 2;
            this.btnWijzigen.Text = "Wijzigen";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(391, 70);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(192, 23);
            this.btnVerwijderen.TabIndex = 3;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // picBeertjesportret
            // 
            this.picBeertjesportret.Location = new System.Drawing.Point(391, 99);
            this.picBeertjesportret.Name = "picBeertjesportret";
            this.picBeertjesportret.Size = new System.Drawing.Size(192, 151);
            this.picBeertjesportret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBeertjesportret.TabIndex = 4;
            this.picBeertjesportret.TabStop = false;
            // 
            // frmBeertjeswinkel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 262);
            this.Controls.Add(this.picBeertjesportret);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lstBeertjes);
            this.Name = "frmBeertjeswinkel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beertjeswinkel";
            this.Load += new System.EventHandler(this.frmBeertjeswinkel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBeertjesportret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBeertjes;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.PictureBox picBeertjesportret;
    }
}

