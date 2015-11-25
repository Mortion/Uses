namespace DigitaleKlok
{
    partial class MainForm
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
            this.analogeKlok1 = new DigitaleKlok.AnalogeKlok();
            this.digitaleKlokPainter1 = new DigitaleKlok.DigitaleKlokPainter();
            this.ucDigitaleKlok1 = new DigitaleKlok.ucDigitaleKlok();
            this.SuspendLayout();
            // 
            // analogeKlok1
            // 
            this.analogeKlok1.BackColor = System.Drawing.Color.White;
            this.analogeKlok1.Location = new System.Drawing.Point(23, 302);
            this.analogeKlok1.Name = "analogeKlok1";
            this.analogeKlok1.Size = new System.Drawing.Size(334, 352);
            this.analogeKlok1.TabIndex = 2;
            // 
            // digitaleKlokPainter1
            // 
            this.digitaleKlokPainter1.Location = new System.Drawing.Point(12, 12);
            this.digitaleKlokPainter1.Name = "digitaleKlokPainter1";
            this.digitaleKlokPainter1.Size = new System.Drawing.Size(1293, 312);
            this.digitaleKlokPainter1.TabIndex = 1;
            // 
            // ucDigitaleKlok1
            // 
            this.ucDigitaleKlok1.Location = new System.Drawing.Point(709, 310);
            this.ucDigitaleKlok1.Name = "ucDigitaleKlok1";
            this.ucDigitaleKlok1.Size = new System.Drawing.Size(200, 100);
            this.ucDigitaleKlok1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 788);
            this.Controls.Add(this.analogeKlok1);
            this.Controls.Add(this.digitaleKlokPainter1);
            this.Controls.Add(this.ucDigitaleKlok1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitale klok Showcase";
            this.ResumeLayout(false);

        }


        #endregion

        private ucDigitaleKlok ucDigitaleKlok1;
        private DigitaleKlokPainter digitaleKlokPainter1;
        private AnalogeKlok analogeKlok1;
    }
}

