namespace EasyShopApp
{
    partial class LoginForm
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNieuweGebruiker = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbLoginOnthouden = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(110, 51);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(235, 24);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(110, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(235, 24);
            this.txtPassword.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(22, 54);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(33, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnNieuweGebruiker
            // 
            this.btnNieuweGebruiker.Location = new System.Drawing.Point(110, 167);
            this.btnNieuweGebruiker.Name = "btnNieuweGebruiker";
            this.btnNieuweGebruiker.Size = new System.Drawing.Size(112, 23);
            this.btnNieuweGebruiker.TabIndex = 4;
            this.btnNieuweGebruiker.Text = "Nieuwe Gebruiker?";
            this.btnNieuweGebruiker.UseVisualStyleBackColor = true;
            this.btnNieuweGebruiker.Click += new System.EventHandler(this.btnNieuweGebruiker_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(228, 167);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbLoginOnthouden
            // 
            this.cbLoginOnthouden.AutoSize = true;
            this.cbLoginOnthouden.Location = new System.Drawing.Point(110, 135);
            this.cbLoginOnthouden.Name = "cbLoginOnthouden";
            this.cbLoginOnthouden.Size = new System.Drawing.Size(112, 17);
            this.cbLoginOnthouden.TabIndex = 6;
            this.cbLoginOnthouden.Text = "Login onthouden?";
            this.cbLoginOnthouden.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 197);
            this.Controls.Add(this.cbLoginOnthouden);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNieuweGebruiker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Easy Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNieuweGebruiker;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbLoginOnthouden;
    }
}

