namespace Herhalingsoefening_Programmeren2_01
{
    partial class frmQuantiteit
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
            this.btnAantalArtikels = new System.Windows.Forms.Button();
            this.nmAantalProduct = new System.Windows.Forms.NumericUpDown();
            this.lblAantalProduct = new System.Windows.Forms.Label();
            this.lblVraagAantal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmAantalProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAantalArtikels
            // 
            this.btnAantalArtikels.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAantalArtikels.Location = new System.Drawing.Point(86, 150);
            this.btnAantalArtikels.Name = "btnAantalArtikels";
            this.btnAantalArtikels.Size = new System.Drawing.Size(153, 23);
            this.btnAantalArtikels.TabIndex = 7;
            this.btnAantalArtikels.Text = "Voeg toe";
            this.btnAantalArtikels.UseVisualStyleBackColor = true;
            // 
            // nmAantalProduct
            // 
            this.nmAantalProduct.Location = new System.Drawing.Point(100, 115);
            this.nmAantalProduct.Name = "nmAantalProduct";
            this.nmAantalProduct.Size = new System.Drawing.Size(120, 20);
            this.nmAantalProduct.TabIndex = 6;
            // 
            // lblAantalProduct
            // 
            this.lblAantalProduct.AutoSize = true;
            this.lblAantalProduct.Location = new System.Drawing.Point(12, 117);
            this.lblAantalProduct.Name = "lblAantalProduct";
            this.lblAantalProduct.Size = new System.Drawing.Size(37, 13);
            this.lblAantalProduct.TabIndex = 5;
            this.lblAantalProduct.Text = "Aantal";
            // 
            // lblVraagAantal
            // 
            this.lblVraagAantal.AutoSize = true;
            this.lblVraagAantal.Location = new System.Drawing.Point(12, 9);
            this.lblVraagAantal.Name = "lblVraagAantal";
            this.lblVraagAantal.Size = new System.Drawing.Size(39, 13);
            this.lblVraagAantal.TabIndex = 4;
            this.lblVraagAantal.Text = "#stuks";
            // 
            // frmQuantiteit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 187);
            this.Controls.Add(this.btnAantalArtikels);
            this.Controls.Add(this.nmAantalProduct);
            this.Controls.Add(this.lblAantalProduct);
            this.Controls.Add(this.lblVraagAantal);
            this.Name = "frmQuantiteit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuantiteit";
            ((System.ComponentModel.ISupportInitialize)(this.nmAantalProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAantalArtikels;
        internal System.Windows.Forms.NumericUpDown nmAantalProduct;
        internal System.Windows.Forms.Label lblAantalProduct;
        internal System.Windows.Forms.Label lblVraagAantal;
    }
}