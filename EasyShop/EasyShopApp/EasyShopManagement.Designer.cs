namespace EasyShopApp
{
    partial class EasyShopManagement
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
            this.btnShopManagement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShopManagement
            // 
            this.btnShopManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopManagement.Location = new System.Drawing.Point(12, 12);
            this.btnShopManagement.Name = "btnShopManagement";
            this.btnShopManagement.Size = new System.Drawing.Size(206, 237);
            this.btnShopManagement.TabIndex = 0;
            this.btnShopManagement.Text = "Shop Management";
            this.btnShopManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShopManagement.UseVisualStyleBackColor = true;
            this.btnShopManagement.Click += new System.EventHandler(this.btnShopManagement_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 237);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 237);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EasyShopManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShopManagement);
            this.Name = "EasyShopManagement";
            this.Text = "EasyShopManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShopManagement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}