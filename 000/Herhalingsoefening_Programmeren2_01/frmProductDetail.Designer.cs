namespace Herhalingsoefening_Programmeren2_01
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
            this.txtPrijsProduct = new System.Windows.Forms.TextBox();
            this.txtNaamProduct = new System.Windows.Forms.TextBox();
            this.txtCodeProduct = new System.Windows.Forms.TextBox();
            this.btnBewaar = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.lblPrijsProduct = new System.Windows.Forms.Label();
            this.lblNaamProduct = new System.Windows.Forms.Label();
            this.lblCodeProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrijsProduct
            // 
            this.txtPrijsProduct.Location = new System.Drawing.Point(87, 51);
            this.txtPrijsProduct.Name = "txtPrijsProduct";
            this.txtPrijsProduct.Size = new System.Drawing.Size(100, 20);
            this.txtPrijsProduct.TabIndex = 15;
            // 
            // txtNaamProduct
            // 
            this.txtNaamProduct.Location = new System.Drawing.Point(87, 28);
            this.txtNaamProduct.Name = "txtNaamProduct";
            this.txtNaamProduct.Size = new System.Drawing.Size(100, 20);
            this.txtNaamProduct.TabIndex = 14;
            // 
            // txtCodeProduct
            // 
            this.txtCodeProduct.Location = new System.Drawing.Point(87, 6);
            this.txtCodeProduct.Name = "txtCodeProduct";
            this.txtCodeProduct.Size = new System.Drawing.Size(100, 20);
            this.txtCodeProduct.TabIndex = 13;
            // 
            // btnBewaar
            // 
            this.btnBewaar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBewaar.Location = new System.Drawing.Point(108, 80);
            this.btnBewaar.Name = "btnBewaar";
            this.btnBewaar.Size = new System.Drawing.Size(98, 23);
            this.btnBewaar.TabIndex = 12;
            this.btnBewaar.Text = "Bewaar";
            this.btnBewaar.UseVisualStyleBackColor = true;
            this.btnBewaar.Click += new System.EventHandler(this.btnBewaar_Click);
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuleer.Location = new System.Drawing.Point(15, 80);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(87, 23);
            this.btnAnnuleer.TabIndex = 11;
            this.btnAnnuleer.Text = "Annuleer";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // lblPrijsProduct
            // 
            this.lblPrijsProduct.AutoSize = true;
            this.lblPrijsProduct.Location = new System.Drawing.Point(12, 54);
            this.lblPrijsProduct.Name = "lblPrijsProduct";
            this.lblPrijsProduct.Size = new System.Drawing.Size(26, 13);
            this.lblPrijsProduct.TabIndex = 10;
            this.lblPrijsProduct.Text = "Prijs";
            // 
            // lblNaamProduct
            // 
            this.lblNaamProduct.AutoSize = true;
            this.lblNaamProduct.Location = new System.Drawing.Point(12, 31);
            this.lblNaamProduct.Name = "lblNaamProduct";
            this.lblNaamProduct.Size = new System.Drawing.Size(35, 13);
            this.lblNaamProduct.TabIndex = 9;
            this.lblNaamProduct.Text = "Naam";
            // 
            // lblCodeProduct
            // 
            this.lblCodeProduct.AutoSize = true;
            this.lblCodeProduct.Location = new System.Drawing.Point(12, 9);
            this.lblCodeProduct.Name = "lblCodeProduct";
            this.lblCodeProduct.Size = new System.Drawing.Size(32, 13);
            this.lblCodeProduct.TabIndex = 8;
            this.lblCodeProduct.Text = "Code";
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 115);
            this.Controls.Add(this.txtPrijsProduct);
            this.Controls.Add(this.txtNaamProduct);
            this.Controls.Add(this.txtCodeProduct);
            this.Controls.Add(this.btnBewaar);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.lblPrijsProduct);
            this.Controls.Add(this.lblNaamProduct);
            this.Controls.Add(this.lblCodeProduct);
            this.Name = "frmProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPrijsProduct;
        internal System.Windows.Forms.TextBox txtNaamProduct;
        internal System.Windows.Forms.TextBox txtCodeProduct;
        internal System.Windows.Forms.Button btnBewaar;
        internal System.Windows.Forms.Button btnAnnuleer;
        internal System.Windows.Forms.Label lblPrijsProduct;
        internal System.Windows.Forms.Label lblNaamProduct;
        internal System.Windows.Forms.Label lblCodeProduct;
    }
}