namespace DigitaleKlok
{
    partial class AnalogeKlok
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
            this.picAnalogeKlok = new System.Windows.Forms.PictureBox();
            this.tmrSeconden = new System.Windows.Forms.Timer(this.components);
            this.tmrMinuten = new System.Windows.Forms.Timer(this.components);
            this.tmrUur = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAnalogeKlok)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnalogeKlok
            // 
            this.picAnalogeKlok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnalogeKlok.Location = new System.Drawing.Point(3, 3);
            this.picAnalogeKlok.Name = "picAnalogeKlok";
            this.picAnalogeKlok.Size = new System.Drawing.Size(340, 340);
            this.picAnalogeKlok.TabIndex = 0;
            this.picAnalogeKlok.TabStop = false;
      
            // 
            // AnalogeKlok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picAnalogeKlok);
            this.Name = "AnalogeKlok";
            this.Size = new System.Drawing.Size(347, 347);
            ((System.ComponentModel.ISupportInitialize)(this.picAnalogeKlok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnalogeKlok;
        private System.Windows.Forms.Timer tmrSeconden;
        private System.Windows.Forms.Timer tmrMinuten;
        private System.Windows.Forms.Timer tmrUur;
    }
}
