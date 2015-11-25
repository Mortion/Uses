namespace DigitaleKlok
{
    partial class ucDigitaleKlok
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblKlokDisplay = new System.Windows.Forms.Label();
            this.tmrTijdKlok = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblKlokDisplay
            // 
            this.lblKlokDisplay.AutoSize = true;
            this.lblKlokDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlokDisplay.Location = new System.Drawing.Point(22, 33);
            this.lblKlokDisplay.Name = "lblKlokDisplay";
            this.lblKlokDisplay.Size = new System.Drawing.Size(153, 31);
            this.lblKlokDisplay.TabIndex = 0;
            this.lblKlokDisplay.Text = "00:00:00:0";
            // 
            // tmrTijdKlok
            // 
            this.tmrTijdKlok.Tick += new System.EventHandler(this.tmrTijdKlok_Tick);
            // 
            // ucDigitaleKlok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKlokDisplay);
            this.Name = "ucDigitaleKlok";
            this.Size = new System.Drawing.Size(200, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlokDisplay;
        private System.Windows.Forms.Timer tmrTijdKlok;
    }
}
