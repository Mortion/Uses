namespace herhalingsoefening
{
    partial class frmWinkeltje
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
            this.lstLinks = new System.Windows.Forms.ListBox();
            this.lstRechts = new System.Windows.Forms.ListBox();
            this.btnRechts = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnWegschrijven = new System.Windows.Forms.Button();
            this.btnLeeg = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblHidden = new System.Windows.Forms.Label();
            this.lblHidden2 = new System.Windows.Forms.Label();
            this.lblProducten = new System.Windows.Forms.Label();
            this.lblMandje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstLinks
            // 
            this.lstLinks.FormattingEnabled = true;
            this.lstLinks.Location = new System.Drawing.Point(37, 51);
            this.lstLinks.Name = "lstLinks";
            this.lstLinks.Size = new System.Drawing.Size(149, 329);
            this.lstLinks.TabIndex = 0;
            // 
            // lstRechts
            // 
            this.lstRechts.FormattingEnabled = true;
            this.lstRechts.Location = new System.Drawing.Point(264, 51);
            this.lstRechts.Name = "lstRechts";
            this.lstRechts.Size = new System.Drawing.Size(149, 329);
            this.lstRechts.TabIndex = 1;
            // 
            // btnRechts
            // 
            this.btnRechts.Location = new System.Drawing.Point(207, 70);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(32, 99);
            this.btnRechts.TabIndex = 2;
            this.btnRechts.Text = ">>";
            this.btnRechts.UseVisualStyleBackColor = true;
            this.btnRechts.Click += new System.EventHandler(this.btnRechts_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.Location = new System.Drawing.Point(207, 250);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(32, 99);
            this.btnLinks.TabIndex = 3;
            this.btnLinks.Text = "<<";
            this.btnLinks.UseVisualStyleBackColor = true;
            this.btnLinks.Click += new System.EventHandler(this.btnLinks_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(37, 398);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(149, 23);
            this.btnToevoegen.TabIndex = 4;
            this.btnToevoegen.Text = "Product Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(37, 439);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(149, 23);
            this.btnVerwijderen.TabIndex = 5;
            this.btnVerwijderen.Text = "Product Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnWegschrijven
            // 
            this.btnWegschrijven.Location = new System.Drawing.Point(37, 506);
            this.btnWegschrijven.Name = "btnWegschrijven";
            this.btnWegschrijven.Size = new System.Drawing.Size(149, 23);
            this.btnWegschrijven.TabIndex = 6;
            this.btnWegschrijven.Text = "Wegschrijven";
            this.btnWegschrijven.UseVisualStyleBackColor = true;
            this.btnWegschrijven.Click += new System.EventHandler(this.btnWegschrijven_Click);
            // 
            // btnLeeg
            // 
            this.btnLeeg.Location = new System.Drawing.Point(264, 398);
            this.btnLeeg.Name = "btnLeeg";
            this.btnLeeg.Size = new System.Drawing.Size(149, 23);
            this.btnLeeg.TabIndex = 10;
            this.btnLeeg.Text = "Mandje Leegmaken";
            this.btnLeeg.UseVisualStyleBackColor = true;
            this.btnLeeg.Click += new System.EventHandler(this.btnLeeg_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(473, 398);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(149, 23);
            this.btnSluiten.TabIndex = 11;
            this.btnSluiten.Text = "Winkel Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(473, 51);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(149, 23);
            this.btnBereken.TabIndex = 12;
            this.btnBereken.Text = "Bereken factuurke";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Location = new System.Drawing.Point(459, 101);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(0, 13);
            this.lblHidden.TabIndex = 13;
            // 
            // lblHidden2
            // 
            this.lblHidden2.AutoSize = true;
            this.lblHidden2.Location = new System.Drawing.Point(462, 145);
            this.lblHidden2.Name = "lblHidden2";
            this.lblHidden2.Size = new System.Drawing.Size(0, 13);
            this.lblHidden2.TabIndex = 14;
            // 
            // lblProducten
            // 
            this.lblProducten.AutoSize = true;
            this.lblProducten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducten.Location = new System.Drawing.Point(58, 16);
            this.lblProducten.Name = "lblProducten";
            this.lblProducten.Size = new System.Drawing.Size(106, 24);
            this.lblProducten.TabIndex = 15;
            this.lblProducten.Text = "Producten";
            // 
            // lblMandje
            // 
            this.lblMandje.AutoSize = true;
            this.lblMandje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMandje.Location = new System.Drawing.Point(297, 16);
            this.lblMandje.Name = "lblMandje";
            this.lblMandje.Size = new System.Drawing.Size(79, 24);
            this.lblMandje.TabIndex = 16;
            this.lblMandje.Text = "Mandje";
            // 
            // frmWinkeltje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 655);
            this.Controls.Add(this.lblMandje);
            this.Controls.Add(this.lblProducten);
            this.Controls.Add(this.lblHidden2);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnLeeg);
            this.Controls.Add(this.btnWegschrijven);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.lstRechts);
            this.Controls.Add(this.lstLinks);
            this.Name = "frmWinkeltje";
            this.Text = "Mijn winkeltje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLinks;
        private System.Windows.Forms.ListBox lstRechts;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnWegschrijven;
        private System.Windows.Forms.Button btnLeeg;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label lblHidden2;
        private System.Windows.Forms.Label lblProducten;
        private System.Windows.Forms.Label lblMandje;
    }
}

