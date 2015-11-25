namespace TheMORTIONProject
{
    partial class MORTION_EYE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MORTION_EYE));
            this.pbEye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEye
            // 
            this.pbEye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEye.Image = ((System.Drawing.Image)(resources.GetObject("pbEye.Image")));
            this.pbEye.Location = new System.Drawing.Point(0, 0);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(416, 466);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEye.TabIndex = 0;
            this.pbEye.TabStop = false;
            // 
            // MORTION_EYE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbEye);
            this.Name = "MORTION_EYE";
            this.Size = new System.Drawing.Size(416, 466);
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEye;
    }
}
