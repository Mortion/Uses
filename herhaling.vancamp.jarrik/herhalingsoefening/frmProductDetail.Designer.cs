namespace herhalingsoefening
{
    partial class frmProductDetail
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.btnBewaar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(36, 35);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(36, 71);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam";
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(36, 105);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(26, 13);
            this.lblPrijs.TabIndex = 2;
            this.lblPrijs.Text = "Prijs";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(121, 32);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 3;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(121, 68);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 4;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(121, 102);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtPrijs.TabIndex = 5;
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuleer.Location = new System.Drawing.Point(39, 160);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(81, 36);
            this.btnAnnuleer.TabIndex = 6;
            this.btnAnnuleer.Text = "Annuleer";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            // 
            // btnBewaar
            // 
            this.btnBewaar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBewaar.Location = new System.Drawing.Point(140, 160);
            this.btnBewaar.Name = "btnBewaar";
            this.btnBewaar.Size = new System.Drawing.Size(81, 36);
            this.btnBewaar.TabIndex = 7;
            this.btnBewaar.Text = "Bewaar";
            this.btnBewaar.UseVisualStyleBackColor = true;
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBewaar);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblCode);
            this.Name = "frmProductDetail";
            this.Text = "frmProductDetail";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.Button btnAnnuleer;
        private System.Windows.Forms.Button btnBewaar;
    }
}