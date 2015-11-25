namespace Herhalingsoefening_Programmeren2_01
{
    partial class frmWinkelmandje
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
            this.lstFactuur = new System.Windows.Forms.ListBox();
            this.btnBerekenFactuur = new System.Windows.Forms.Button();
            this.btnLeegmakenMandje = new System.Windows.Forms.Button();
            this.btnVerwijderenProduct = new System.Windows.Forms.Button();
            this.btnToevoegenProduct = new System.Windows.Forms.Button();
            this.btnVerwijderenMandje = new System.Windows.Forms.Button();
            this.btnToevoegenMandje = new System.Windows.Forms.Button();
            this.lstWinkelmand = new System.Windows.Forms.ListBox();
            this.lstProducten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFactuur
            // 
            this.lstFactuur.BackColor = System.Drawing.SystemColors.Control;
            this.lstFactuur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFactuur.FormattingEnabled = true;
            this.lstFactuur.Location = new System.Drawing.Point(488, 60);
            this.lstFactuur.Name = "lstFactuur";
            this.lstFactuur.Size = new System.Drawing.Size(264, 325);
            this.lstFactuur.TabIndex = 21;
            // 
            // btnBerekenFactuur
            // 
            this.btnBerekenFactuur.Location = new System.Drawing.Point(488, 34);
            this.btnBerekenFactuur.Name = "btnBerekenFactuur";
            this.btnBerekenFactuur.Size = new System.Drawing.Size(131, 23);
            this.btnBerekenFactuur.TabIndex = 20;
            this.btnBerekenFactuur.Text = "Bereken Factuur";
            this.btnBerekenFactuur.UseVisualStyleBackColor = true;
            this.btnBerekenFactuur.Click += new System.EventHandler(this.btnBerekenFactuur_Click);
            // 
            // btnLeegmakenMandje
            // 
            this.btnLeegmakenMandje.Location = new System.Drawing.Point(303, 395);
            this.btnLeegmakenMandje.Name = "btnLeegmakenMandje";
            this.btnLeegmakenMandje.Size = new System.Drawing.Size(131, 23);
            this.btnLeegmakenMandje.TabIndex = 18;
            this.btnLeegmakenMandje.Text = "Mandje Leegmaken";
            this.btnLeegmakenMandje.UseVisualStyleBackColor = true;
            this.btnLeegmakenMandje.Click += new System.EventHandler(this.btnLeegmakenMandje_Click);
            // 
            // btnVerwijderenProduct
            // 
            this.btnVerwijderenProduct.Location = new System.Drawing.Point(149, 395);
            this.btnVerwijderenProduct.Name = "btnVerwijderenProduct";
            this.btnVerwijderenProduct.Size = new System.Drawing.Size(131, 23);
            this.btnVerwijderenProduct.TabIndex = 16;
            this.btnVerwijderenProduct.Text = "Product Verwijderen";
            this.btnVerwijderenProduct.UseVisualStyleBackColor = true;
            this.btnVerwijderenProduct.Click += new System.EventHandler(this.btnVerwijderenProduct_Click);
            // 
            // btnToevoegenProduct
            // 
            this.btnToevoegenProduct.Location = new System.Drawing.Point(12, 395);
            this.btnToevoegenProduct.Name = "btnToevoegenProduct";
            this.btnToevoegenProduct.Size = new System.Drawing.Size(131, 23);
            this.btnToevoegenProduct.TabIndex = 15;
            this.btnToevoegenProduct.Text = "Product Toevoegen";
            this.btnToevoegenProduct.UseVisualStyleBackColor = true;
            this.btnToevoegenProduct.Click += new System.EventHandler(this.btnToevoegenProduct_Click);
            // 
            // btnVerwijderenMandje
            // 
            this.btnVerwijderenMandje.Location = new System.Drawing.Point(232, 210);
            this.btnVerwijderenMandje.Name = "btnVerwijderenMandje";
            this.btnVerwijderenMandje.Size = new System.Drawing.Size(30, 107);
            this.btnVerwijderenMandje.TabIndex = 14;
            this.btnVerwijderenMandje.Text = "<<";
            this.btnVerwijderenMandje.UseVisualStyleBackColor = true;
            this.btnVerwijderenMandje.Click += new System.EventHandler(this.btnVerwijderenMandje_Click);
            // 
            // btnToevoegenMandje
            // 
            this.btnToevoegenMandje.Location = new System.Drawing.Point(232, 45);
            this.btnToevoegenMandje.Name = "btnToevoegenMandje";
            this.btnToevoegenMandje.Size = new System.Drawing.Size(30, 107);
            this.btnToevoegenMandje.TabIndex = 13;
            this.btnToevoegenMandje.Text = ">>";
            this.btnToevoegenMandje.UseVisualStyleBackColor = true;
            this.btnToevoegenMandje.Click += new System.EventHandler(this.btnToevoegenMandje_Click);
            // 
            // lstWinkelmand
            // 
            this.lstWinkelmand.FormattingEnabled = true;
            this.lstWinkelmand.Location = new System.Drawing.Point(268, 34);
            this.lstWinkelmand.Name = "lstWinkelmand";
            this.lstWinkelmand.Size = new System.Drawing.Size(214, 355);
            this.lstWinkelmand.TabIndex = 12;
            this.lstWinkelmand.SelectedIndexChanged += new System.EventHandler(this.lstWinkelmand_SelectedIndexChanged);
            // 
            // lstProducten
            // 
            this.lstProducten.FormattingEnabled = true;
            this.lstProducten.Location = new System.Drawing.Point(12, 34);
            this.lstProducten.Name = "lstProducten";
            this.lstProducten.Size = new System.Drawing.Size(214, 355);
            this.lstProducten.TabIndex = 11;
            this.lstProducten.SelectedIndexChanged += new System.EventHandler(this.indexProducten);
            // 
            // frmWinkelmandje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 437);
            this.Controls.Add(this.lstFactuur);
            this.Controls.Add(this.btnBerekenFactuur);
            this.Controls.Add(this.btnLeegmakenMandje);
            this.Controls.Add(this.btnVerwijderenProduct);
            this.Controls.Add(this.btnToevoegenProduct);
            this.Controls.Add(this.btnVerwijderenMandje);
            this.Controls.Add(this.btnToevoegenMandje);
            this.Controls.Add(this.lstWinkelmand);
            this.Controls.Add(this.lstProducten);
            this.Name = "frmWinkelmandje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWinkelmandje";
            this.Activated += new System.EventHandler(this.toonLijst);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWinkelmandje_FormClosed);
            this.Load += new System.EventHandler(this.frmWinkelmandje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lstFactuur;
        internal System.Windows.Forms.Button btnBerekenFactuur;
        internal System.Windows.Forms.Button btnLeegmakenMandje;
        internal System.Windows.Forms.Button btnVerwijderenProduct;
        internal System.Windows.Forms.Button btnToevoegenProduct;
        internal System.Windows.Forms.Button btnVerwijderenMandje;
        internal System.Windows.Forms.Button btnToevoegenMandje;
        internal System.Windows.Forms.ListBox lstWinkelmand;
        public System.Windows.Forms.ListBox lstProducten;
    }
}