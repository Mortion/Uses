namespace DigitaleKlok
{
    partial class DigitaleKlokPainter
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
            this.picUurLinks = new System.Windows.Forms.PictureBox();
            this.picUurRechts = new System.Windows.Forms.PictureBox();
            this.picMinuutRechts = new System.Windows.Forms.PictureBox();
            this.picMinuutLinks = new System.Windows.Forms.PictureBox();
            this.picSecondeRechts = new System.Windows.Forms.PictureBox();
            this.picSecondeLinks = new System.Windows.Forms.PictureBox();
            this.picMilliseconde = new System.Windows.Forms.PictureBox();
            this.tmrStartUur = new System.Windows.Forms.Timer(this.components);
            this.tmrStartMinuten = new System.Windows.Forms.Timer(this.components);
            this.tmrStartMilliseconden = new System.Windows.Forms.Timer(this.components);
            this.tmrStartSeconden = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picUurLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUurRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinuutRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinuutLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondeRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondeLinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMilliseconde)).BeginInit();
            this.SuspendLayout();
            // 
            // picUurLinks
            // 
            this.picUurLinks.BackColor = System.Drawing.Color.SteelBlue;
            this.picUurLinks.Location = new System.Drawing.Point(26, 29);
            this.picUurLinks.Name = "picUurLinks";
            this.picUurLinks.Size = new System.Drawing.Size(140, 230);
            this.picUurLinks.TabIndex = 0;
            this.picUurLinks.TabStop = false;
            // 
            // picUurRechts
            // 
            this.picUurRechts.BackColor = System.Drawing.Color.SteelBlue;
            this.picUurRechts.Location = new System.Drawing.Point(172, 29);
            this.picUurRechts.Name = "picUurRechts";
            this.picUurRechts.Size = new System.Drawing.Size(140, 230);
            this.picUurRechts.TabIndex = 1;
            this.picUurRechts.TabStop = false;
            // 
            // picMinuutRechts
            // 
            this.picMinuutRechts.BackColor = System.Drawing.Color.SteelBlue;
            this.picMinuutRechts.Location = new System.Drawing.Point(490, 29);
            this.picMinuutRechts.Name = "picMinuutRechts";
            this.picMinuutRechts.Size = new System.Drawing.Size(140, 230);
            this.picMinuutRechts.TabIndex = 3;
            this.picMinuutRechts.TabStop = false;
            // 
            // picMinuutLinks
            // 
            this.picMinuutLinks.BackColor = System.Drawing.Color.SteelBlue;
            this.picMinuutLinks.Location = new System.Drawing.Point(344, 29);
            this.picMinuutLinks.Name = "picMinuutLinks";
            this.picMinuutLinks.Size = new System.Drawing.Size(140, 230);
            this.picMinuutLinks.TabIndex = 2;
            this.picMinuutLinks.TabStop = false;
            // 
            // picSecondeRechts
            // 
            this.picSecondeRechts.BackColor = System.Drawing.Color.SteelBlue;
            this.picSecondeRechts.Location = new System.Drawing.Point(817, 29);
            this.picSecondeRechts.Name = "picSecondeRechts";
            this.picSecondeRechts.Size = new System.Drawing.Size(140, 230);
            this.picSecondeRechts.TabIndex = 5;
            this.picSecondeRechts.TabStop = false;
            // 
            // picSecondeLinks
            // 
            this.picSecondeLinks.BackColor = System.Drawing.Color.SteelBlue;
            this.picSecondeLinks.Location = new System.Drawing.Point(671, 29);
            this.picSecondeLinks.Name = "picSecondeLinks";
            this.picSecondeLinks.Size = new System.Drawing.Size(140, 230);
            this.picSecondeLinks.TabIndex = 4;
            this.picSecondeLinks.TabStop = false;
            // 
            // picMilliseconde
            // 
            this.picMilliseconde.BackColor = System.Drawing.Color.SteelBlue;
            this.picMilliseconde.Location = new System.Drawing.Point(1058, 29);
            this.picMilliseconde.Name = "picMilliseconde";
            this.picMilliseconde.Size = new System.Drawing.Size(140, 230);
            this.picMilliseconde.TabIndex = 6;
            this.picMilliseconde.TabStop = false;
            // 
            // tmrStartUur
            // 
            this.tmrStartUur.Interval = 1;
            this.tmrStartUur.Tick += new System.EventHandler(this.tmrStartUur_Tick);
            // 
            // tmrStartMinuten
            // 
            this.tmrStartMinuten.Interval = 1;
            this.tmrStartMinuten.Tick += new System.EventHandler(this.tmrStartMinuten_Tick_1);
            // 
            // tmrStartMilliseconden
            // 
            this.tmrStartMilliseconden.Interval = 1;
            this.tmrStartMilliseconden.Tick += new System.EventHandler(this.tmrStartMilliseconden_Tick_1);
            // 
            // tmrStartSeconden
            // 
            this.tmrStartSeconden.Interval = 1;
            this.tmrStartSeconden.Tick += new System.EventHandler(this.tmrStartSeconden_Tick);
            // 
            // DigitaleKlokPainter
            // 
            this.Controls.Add(this.picMilliseconde);
            this.Controls.Add(this.picSecondeRechts);
            this.Controls.Add(this.picSecondeLinks);
            this.Controls.Add(this.picMinuutRechts);
            this.Controls.Add(this.picMinuutLinks);
            this.Controls.Add(this.picUurRechts);
            this.Controls.Add(this.picUurLinks);
            this.Name = "DigitaleKlokPainter";
            this.Size = new System.Drawing.Size(1253, 312);
            ((System.ComponentModel.ISupportInitialize)(this.picUurLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUurRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinuutRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinuutLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondeRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondeLinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMilliseconde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picUurLinks;
        private System.Windows.Forms.PictureBox picUurRechts;
        private System.Windows.Forms.PictureBox picMinuutRechts;
        private System.Windows.Forms.PictureBox picMinuutLinks;
        private System.Windows.Forms.PictureBox picSecondeRechts;
        private System.Windows.Forms.PictureBox picSecondeLinks;
        private System.Windows.Forms.PictureBox picMilliseconde;
        private System.Windows.Forms.Timer tmrStartUur;
        private System.Windows.Forms.Timer tmrStartMinuten;
        private System.Windows.Forms.Timer tmrStartMilliseconden;
        private System.Windows.Forms.Timer tmrStartSeconden;
    }
}
