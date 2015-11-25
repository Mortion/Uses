namespace HerhalingsOefeningJarrikVanCampLuchthaven
{
    partial class UserDataControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.rbMaleGender = new System.Windows.Forms.RadioButton();
            this.rbFemaleGender = new System.Windows.Forms.RadioButton();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(108, 10);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(177, 20);
            this.txtFirstname.TabIndex = 4;
            this.txtFirstname.TextChanged += new System.EventHandler(this.txtFirstname_TextChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(108, 42);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(177, 20);
            this.txtLastname.TabIndex = 5;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            // 
            // rbMaleGender
            // 
            this.rbMaleGender.AutoSize = true;
            this.rbMaleGender.Checked = true;
            this.rbMaleGender.Location = new System.Drawing.Point(108, 109);
            this.rbMaleGender.Name = "rbMaleGender";
            this.rbMaleGender.Size = new System.Drawing.Size(48, 17);
            this.rbMaleGender.TabIndex = 7;
            this.rbMaleGender.TabStop = true;
            this.rbMaleGender.Text = "Male";
            this.rbMaleGender.UseVisualStyleBackColor = true;
            this.rbMaleGender.CheckedChanged += new System.EventHandler(this.rbMaleGender_CheckedChanged);
            // 
            // rbFemaleGender
            // 
            this.rbFemaleGender.AutoSize = true;
            this.rbFemaleGender.Location = new System.Drawing.Point(199, 109);
            this.rbFemaleGender.Name = "rbFemaleGender";
            this.rbFemaleGender.Size = new System.Drawing.Size(59, 17);
            this.rbFemaleGender.TabIndex = 8;
            this.rbFemaleGender.Text = "Female";
            this.rbFemaleGender.UseVisualStyleBackColor = true;
            this.rbFemaleGender.CheckedChanged += new System.EventHandler(this.rbMaleGender_CheckedChanged);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(108, 71);
            this.dtBirthdate.MinDate = new System.DateTime(1839, 1, 1, 0, 0, 0, 0);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(177, 20);
            this.dtBirthdate.TabIndex = 9;
            this.dtBirthdate.ValueChanged += new System.EventHandler(this.dtBirthdate_ValueChanged);
            // 
            // UserDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.rbFemaleGender);
            this.Controls.Add(this.rbMaleGender);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserDataControl";
            this.Size = new System.Drawing.Size(288, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtFirstname;
        public System.Windows.Forms.TextBox txtLastname;
        public System.Windows.Forms.RadioButton rbMaleGender;
        public System.Windows.Forms.RadioButton rbFemaleGender;
        public System.Windows.Forms.DateTimePicker dtBirthdate;
    }
}
