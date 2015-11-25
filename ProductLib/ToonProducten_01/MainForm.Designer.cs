namespace ToonProducten_01
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
            this.lstProducten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstProducten
            // 
            this.lstProducten.FormattingEnabled = true;
            this.lstProducten.Location = new System.Drawing.Point(12, 12);
            this.lstProducten.Name = "lstProducten";
            this.lstProducten.Size = new System.Drawing.Size(514, 472);
            this.lstProducten.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 575);
            this.Controls.Add(this.lstProducten);
            this.Name = "MainForm";
            this.Text = "Producten";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducten;
    }
}

