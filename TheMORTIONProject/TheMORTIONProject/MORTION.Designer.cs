namespace TheMORTIONProject
{
    partial class frmMORTION
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
            this.lblWeather = new System.Windows.Forms.Label();
            this.date1 = new TheMORTIONProject.Date();
            this.digitalClock1 = new TheMORTIONProject.DigitalClock();
            this.grpDateTimeWeather1 = new TheMORTIONProject.grpDateTimeWeather();
            this.mortioN_EYE1 = new TheMORTIONProject.MORTION_EYE();
            this.SuspendLayout();
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(408, 22);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(86, 31);
            this.lblWeather.TabIndex = 4;
            this.lblWeather.Text = "label1";
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.date1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date1.Location = new System.Drawing.Point(770, 22);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(153, 38);
            this.date1.TabIndex = 3;
            // 
            // digitalClock1
            // 
            this.digitalClock1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.digitalClock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digitalClock1.Location = new System.Drawing.Point(590, 67);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(150, 35);
            this.digitalClock1.TabIndex = 2;
            // 
            // grpDateTimeWeather1
            // 
            this.grpDateTimeWeather1.BackColor = System.Drawing.Color.Transparent;
            this.grpDateTimeWeather1.Location = new System.Drawing.Point(276, -8);
            this.grpDateTimeWeather1.Name = "grpDateTimeWeather1";
            this.grpDateTimeWeather1.Size = new System.Drawing.Size(783, 145);
            this.grpDateTimeWeather1.TabIndex = 1;
            // 
            // mortioN_EYE1
            // 
            this.mortioN_EYE1.BackColor = System.Drawing.Color.Transparent;
            this.mortioN_EYE1.Location = new System.Drawing.Point(508, 199);
            this.mortioN_EYE1.Name = "mortioN_EYE1";
            this.mortioN_EYE1.Size = new System.Drawing.Size(284, 373);
            this.mortioN_EYE1.TabIndex = 0;
            // 
            // frmMORTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1305, 732);
            this.ControlBox = false;
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.grpDateTimeWeather1);
            this.Controls.Add(this.mortioN_EYE1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMORTION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMORTION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MORTION_EYE mortioN_EYE1;
        private grpDateTimeWeather grpDateTimeWeather1;
        private DigitalClock digitalClock1;
        private Date date1;
        private System.Windows.Forms.Label lblWeather;
    }
}

