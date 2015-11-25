namespace herhalingsoefening
{
    partial class frmQuantity
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
            this.btnAankopen = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAankopen
            // 
            this.btnAankopen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAankopen.Location = new System.Drawing.Point(100, 132);
            this.btnAankopen.Name = "btnAankopen";
            this.btnAankopen.Size = new System.Drawing.Size(120, 23);
            this.btnAankopen.TabIndex = 0;
            this.btnAankopen.Text = "Aankopen";
            this.btnAankopen.UseVisualStyleBackColor = true;
            this.btnAankopen.Click += new System.EventHandler(this.btnAankopen_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 60);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(241, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Hoeveel stuks wenst u aan te kopen van product";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(26, 99);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 2;
            this.lblAantal.Text = "Aantal";
            // 
            // numUD
            // 
            this.numUD.Location = new System.Drawing.Point(100, 97);
            this.numUD.Name = "numUD";
            this.numUD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numUD.Size = new System.Drawing.Size(120, 20);
            this.numUD.TabIndex = 3;
            // 
            // frmQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 178);
            this.Controls.Add(this.numUD);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnAankopen);
            this.Name = "frmQuantity";
            this.Text = "frmQuantity";
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAankopen;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.NumericUpDown numUD;
    }
}