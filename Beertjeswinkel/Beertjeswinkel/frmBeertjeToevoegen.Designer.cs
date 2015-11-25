namespace Beertjeswinkel
{
    partial class frmBeertjeToevoegen
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
            this.picAfbeeldingBeertje = new System.Windows.Forms.PictureBox();
            this.btnZoekAfbeelding = new System.Windows.Forms.Button();
            this.txtAfbeeldingPath = new System.Windows.Forms.TextBox();
            this.rbPlushe = new System.Windows.Forms.RadioButton();
            this.rbElektronisch = new System.Windows.Forms.RadioButton();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtWasprogramma = new System.Windows.Forms.TextBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.nmAantalBatterijen = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picAfbeeldingBeertje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAantalBatterijen)).BeginInit();
            this.SuspendLayout();
            // 
            // picAfbeeldingBeertje
            // 
            this.picAfbeeldingBeertje.Location = new System.Drawing.Point(12, 12);
            this.picAfbeeldingBeertje.Name = "picAfbeeldingBeertje";
            this.picAfbeeldingBeertje.Size = new System.Drawing.Size(125, 84);
            this.picAfbeeldingBeertje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAfbeeldingBeertje.TabIndex = 0;
            this.picAfbeeldingBeertje.TabStop = false;
            // 
            // btnZoekAfbeelding
            // 
            this.btnZoekAfbeelding.Location = new System.Drawing.Point(485, 12);
            this.btnZoekAfbeelding.Name = "btnZoekAfbeelding";
            this.btnZoekAfbeelding.Size = new System.Drawing.Size(75, 23);
            this.btnZoekAfbeelding.TabIndex = 1;
            this.btnZoekAfbeelding.Text = "...";
            this.btnZoekAfbeelding.UseVisualStyleBackColor = true;
            this.btnZoekAfbeelding.Click += new System.EventHandler(this.btnZoekAfbeelding_Click);
            // 
            // txtAfbeeldingPath
            // 
            this.txtAfbeeldingPath.Location = new System.Drawing.Point(158, 14);
            this.txtAfbeeldingPath.Name = "txtAfbeeldingPath";
            this.txtAfbeeldingPath.ReadOnly = true;
            this.txtAfbeeldingPath.Size = new System.Drawing.Size(321, 20);
            this.txtAfbeeldingPath.TabIndex = 2;
            // 
            // rbPlushe
            // 
            this.rbPlushe.AutoSize = true;
            this.rbPlushe.Checked = true;
            this.rbPlushe.Location = new System.Drawing.Point(177, 40);
            this.rbPlushe.Name = "rbPlushe";
            this.rbPlushe.Size = new System.Drawing.Size(92, 17);
            this.rbPlushe.TabIndex = 3;
            this.rbPlushe.TabStop = true;
            this.rbPlushe.Text = "Plushe beertje";
            this.rbPlushe.UseVisualStyleBackColor = true;
            this.rbPlushe.CheckedChanged += new System.EventHandler(this.PlusheOfElektrisch);
            // 
            // rbElektronisch
            // 
            this.rbElektronisch.AutoSize = true;
            this.rbElektronisch.Location = new System.Drawing.Point(333, 40);
            this.rbElektronisch.Name = "rbElektronisch";
            this.rbElektronisch.Size = new System.Drawing.Size(118, 17);
            this.rbElektronisch.TabIndex = 4;
            this.rbElektronisch.TabStop = true;
            this.rbElektronisch.Text = "Elektronisch beertje";
            this.rbElektronisch.UseVisualStyleBackColor = true;
            this.rbElektronisch.CheckedChanged += new System.EventHandler(this.PlusheOfElektrisch);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(158, 122);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(402, 20);
            this.txtNaam.TabIndex = 5;
            // 
            // txtWasprogramma
            // 
            this.txtWasprogramma.Location = new System.Drawing.Point(158, 160);
            this.txtWasprogramma.Name = "txtWasprogramma";
            this.txtWasprogramma.Size = new System.Drawing.Size(402, 20);
            this.txtWasprogramma.TabIndex = 6;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuleren.Location = new System.Drawing.Point(404, 218);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleren.TabIndex = 7;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(485, 218);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(42, 125);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 9;
            this.lblNaam.Text = "Naam";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(42, 163);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(81, 13);
            this.lblExtra.TabIndex = 10;
            this.lblExtra.Text = "Wasprogramma";
            // 
            // nmAantalBatterijen
            // 
            this.nmAantalBatterijen.Location = new System.Drawing.Point(440, 161);
            this.nmAantalBatterijen.Name = "nmAantalBatterijen";
            this.nmAantalBatterijen.Size = new System.Drawing.Size(120, 20);
            this.nmAantalBatterijen.TabIndex = 11;
            this.nmAantalBatterijen.Visible = false;
            // 
            // frmBeertjeToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 253);
            this.Controls.Add(this.nmAantalBatterijen);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.txtWasprogramma);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.rbElektronisch);
            this.Controls.Add(this.rbPlushe);
            this.Controls.Add(this.txtAfbeeldingPath);
            this.Controls.Add(this.btnZoekAfbeelding);
            this.Controls.Add(this.picAfbeeldingBeertje);
            this.Name = "frmBeertjeToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeertjeToevoegen_FormClosing);
            this.Load += new System.EventHandler(this.frmBeertjeToevoegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAfbeeldingBeertje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAantalBatterijen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAfbeeldingBeertje;
        private System.Windows.Forms.Button btnZoekAfbeelding;
        private System.Windows.Forms.TextBox txtAfbeeldingPath;
        private System.Windows.Forms.RadioButton rbPlushe;
        private System.Windows.Forms.RadioButton rbElektronisch;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtWasprogramma;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.NumericUpDown nmAantalBatterijen;
    }
}