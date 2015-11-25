namespace HerhalingsOefeningJarrikVanCampLuchthaven
{
    partial class frmCrewManagement
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
            this.udcCrewData = new HerhalingsOefeningJarrikVanCampLuchthaven.UserDataControl();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCertificat = new System.Windows.Forms.Label();
            this.rbPilot = new System.Windows.Forms.RadioButton();
            this.rbCrew = new System.Windows.Forms.RadioButton();
            this.lstCertificats = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // udcCrewData
            // 
            this.udcCrewData.Birthdate = new System.DateTime(((long)(0)));
            this.udcCrewData.Firstname = null;
            this.udcCrewData.GenderUser = LuchthavenLibrary.Gender.Male;
            this.udcCrewData.Lastname = null;
            this.udcCrewData.Location = new System.Drawing.Point(6, 34);
            this.udcCrewData.Name = "udcCrewData";
            this.udcCrewData.Size = new System.Drawing.Size(288, 140);
            this.udcCrewData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crewmember type";
            // 
            // lblCertificat
            // 
            this.lblCertificat.AutoSize = true;
            this.lblCertificat.Location = new System.Drawing.Point(21, 177);
            this.lblCertificat.Name = "lblCertificat";
            this.lblCertificat.Size = new System.Drawing.Size(63, 13);
            this.lblCertificat.TabIndex = 2;
            this.lblCertificat.Text = "Certificat for";
            // 
            // rbPilot
            // 
            this.rbPilot.AutoSize = true;
            this.rbPilot.Checked = true;
            this.rbPilot.Location = new System.Drawing.Point(115, 16);
            this.rbPilot.Name = "rbPilot";
            this.rbPilot.Size = new System.Drawing.Size(45, 17);
            this.rbPilot.TabIndex = 3;
            this.rbPilot.TabStop = true;
            this.rbPilot.Text = "Pilot";
            this.rbPilot.UseVisualStyleBackColor = true;
            this.rbPilot.CheckedChanged += new System.EventHandler(this.rbPilot_CheckedChanged);
            // 
            // rbCrew
            // 
            this.rbCrew.AutoSize = true;
            this.rbCrew.Location = new System.Drawing.Point(209, 16);
            this.rbCrew.Name = "rbCrew";
            this.rbCrew.Size = new System.Drawing.Size(49, 17);
            this.rbCrew.TabIndex = 4;
            this.rbCrew.Text = "Crew";
            this.rbCrew.UseVisualStyleBackColor = true;
            this.rbCrew.CheckedChanged += new System.EventHandler(this.rbPilot_CheckedChanged);
            // 
            // lstCertificats
            // 
            this.lstCertificats.FormattingEnabled = true;
            this.lstCertificats.Location = new System.Drawing.Point(115, 177);
            this.lstCertificats.Name = "lstCertificats";
            this.lstCertificats.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCertificats.Size = new System.Drawing.Size(179, 134);
            this.lstCertificats.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(115, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(219, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCrewManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 359);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstCertificats);
            this.Controls.Add(this.rbCrew);
            this.Controls.Add(this.rbPilot);
            this.Controls.Add(this.lblCertificat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udcCrewData);
            this.Name = "frmCrewManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrewManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserDataControl udcCrewData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCertificat;
        private System.Windows.Forms.RadioButton rbPilot;
        private System.Windows.Forms.RadioButton rbCrew;
        private System.Windows.Forms.ListBox lstCertificats;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}