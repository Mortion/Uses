namespace UNO
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnUnoOpenKaart = new System.Windows.Forms.Button();
            this.btnUnoStapel = new System.Windows.Forms.Button();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.grpHand = new System.Windows.Forms.GroupBox();
            this.btnHand7 = new System.Windows.Forms.Button();
            this.btnHand6 = new System.Windows.Forms.Button();
            this.btnHand5 = new System.Windows.Forms.Button();
            this.btnHand4 = new System.Windows.Forms.Button();
            this.btnHand3 = new System.Windows.Forms.Button();
            this.btnHand2 = new System.Windows.Forms.Button();
            this.btnHand1 = new System.Windows.Forms.Button();
            this.lstTest = new System.Windows.Forms.ListBox();
            this.picTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.grpHand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnoOpenKaart
            // 
            this.btnUnoOpenKaart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUnoOpenKaart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnoOpenKaart.ForeColor = System.Drawing.Color.White;
            this.btnUnoOpenKaart.Location = new System.Drawing.Point(270, 108);
            this.btnUnoOpenKaart.Name = "btnUnoOpenKaart";
            this.btnUnoOpenKaart.Size = new System.Drawing.Size(79, 108);
            this.btnUnoOpenKaart.TabIndex = 0;
            this.btnUnoOpenKaart.UseVisualStyleBackColor = true;
            // 
            // btnUnoStapel
            // 
            this.btnUnoStapel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUnoStapel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnoStapel.ForeColor = System.Drawing.Color.White;
            this.btnUnoStapel.Image = ((System.Drawing.Image)(resources.GetObject("btnUnoStapel.Image")));
            this.btnUnoStapel.Location = new System.Drawing.Point(355, 108);
            this.btnUnoStapel.Name = "btnUnoStapel";
            this.btnUnoStapel.Size = new System.Drawing.Size(79, 108);
            this.btnUnoStapel.TabIndex = 1;
            this.btnUnoStapel.UseVisualStyleBackColor = true;
            // 
            // picBackground
            // 
            this.picBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackground.BackgroundImage")));
            this.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground.Location = new System.Drawing.Point(12, 12);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(661, 330);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 2;
            this.picBackground.TabStop = false;
            // 
            // grpHand
            // 
            this.grpHand.Controls.Add(this.btnHand7);
            this.grpHand.Controls.Add(this.btnHand6);
            this.grpHand.Controls.Add(this.btnHand5);
            this.grpHand.Controls.Add(this.btnHand4);
            this.grpHand.Controls.Add(this.btnHand3);
            this.grpHand.Controls.Add(this.btnHand2);
            this.grpHand.Controls.Add(this.btnHand1);
            this.grpHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpHand.Location = new System.Drawing.Point(13, 352);
            this.grpHand.Name = "grpHand";
            this.grpHand.Size = new System.Drawing.Size(659, 135);
            this.grpHand.TabIndex = 3;
            this.grpHand.TabStop = false;
            this.grpHand.Text = "Hand";
            // 
            // btnHand7
            // 
            this.btnHand7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHand7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHand7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand7.ForeColor = System.Drawing.Color.White;
            this.btnHand7.Location = new System.Drawing.Point(546, 25);
            this.btnHand7.Name = "btnHand7";
            this.btnHand7.Size = new System.Drawing.Size(79, 90);
            this.btnHand7.TabIndex = 12;
            this.btnHand7.UseVisualStyleBackColor = false;
            this.btnHand7.Click += new System.EventHandler(this.SpeelKaart);
            // 
            // btnHand6
            // 
            this.btnHand6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHand6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHand6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand6.ForeColor = System.Drawing.Color.White;
            this.btnHand6.Location = new System.Drawing.Point(461, 25);
            this.btnHand6.Name = "btnHand6";
            this.btnHand6.Size = new System.Drawing.Size(79, 90);
            this.btnHand6.TabIndex = 11;
            this.btnHand6.UseVisualStyleBackColor = false;
            this.btnHand6.Click += new System.EventHandler(this.SpeelKaart);
            // 
            // btnHand5
            // 
            this.btnHand5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHand5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHand5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand5.ForeColor = System.Drawing.Color.White;
            this.btnHand5.Location = new System.Drawing.Point(376, 25);
            this.btnHand5.Name = "btnHand5";
            this.btnHand5.Size = new System.Drawing.Size(79, 90);
            this.btnHand5.TabIndex = 10;
            this.btnHand5.UseVisualStyleBackColor = false;
            this.btnHand5.Click += new System.EventHandler(this.SpeelKaart);
            // 
            // btnHand4
            // 
            this.btnHand4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHand4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHand4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand4.ForeColor = System.Drawing.Color.White;
            this.btnHand4.Location = new System.Drawing.Point(291, 25);
            this.btnHand4.Name = "btnHand4";
            this.btnHand4.Size = new System.Drawing.Size(79, 90);
            this.btnHand4.TabIndex = 9;
            this.btnHand4.UseVisualStyleBackColor = false;
            this.btnHand4.Click += new System.EventHandler(this.SpeelKaart);
            // 
            // btnHand3
            // 
            this.btnHand3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHand3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHand3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand3.ForeColor = System.Drawing.Color.White;
            this.btnHand3.Location = new System.Drawing.Point(206, 25);
            this.btnHand3.Name = "btnHand3";
            this.btnHand3.Size = new System.Drawing.Size(79, 90);
            this.btnHand3.TabIndex = 8;
            this.btnHand3.UseVisualStyleBackColor = false;
            this.btnHand3.Click += new System.EventHandler(this.SpeelKaart);
            // 
            // btnHand2
            // 
            this.btnHand2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHand2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHand2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand2.ForeColor = System.Drawing.Color.White;
            this.btnHand2.Location = new System.Drawing.Point(121, 25);
            this.btnHand2.Name = "btnHand2";
            this.btnHand2.Size = new System.Drawing.Size(79, 90);
            this.btnHand2.TabIndex = 7;
            this.btnHand2.UseVisualStyleBackColor = false;
            this.btnHand2.Click += new System.EventHandler(this.SpeelKaart);
            // 
            // btnHand1
            // 
            this.btnHand1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHand1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHand1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand1.ForeColor = System.Drawing.Color.White;
            this.btnHand1.Location = new System.Drawing.Point(36, 25);
            this.btnHand1.Name = "btnHand1";
            this.btnHand1.Size = new System.Drawing.Size(79, 90);
            this.btnHand1.TabIndex = 6;
            this.btnHand1.UseVisualStyleBackColor = false;
            this.btnHand1.Click += new System.EventHandler(this.SpeelKaart);
            // 
            // lstTest
            // 
            this.lstTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.lstTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTest.ForeColor = System.Drawing.SystemColors.Window;
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 25;
            this.lstTest.Location = new System.Drawing.Point(732, 12);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(478, 204);
            this.lstTest.TabIndex = 4;
            // 
            // picTest
            // 
            this.picTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTest.Location = new System.Drawing.Point(765, 239);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(424, 224);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTest.TabIndex = 5;
            this.picTest.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 499);
            this.Controls.Add(this.picTest);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.grpHand);
            this.Controls.Add(this.btnUnoStapel);
            this.Controls.Add(this.btnUnoOpenKaart);
            this.Controls.Add(this.picBackground);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNO -- Jarrik Van Camp";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.grpHand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnoOpenKaart;
        private System.Windows.Forms.Button btnUnoStapel;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.GroupBox grpHand;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.Button btnHand7;
        private System.Windows.Forms.Button btnHand6;
        private System.Windows.Forms.Button btnHand5;
        private System.Windows.Forms.Button btnHand4;
        private System.Windows.Forms.Button btnHand3;
        private System.Windows.Forms.Button btnHand2;
        private System.Windows.Forms.Button btnHand1;
    }
}

