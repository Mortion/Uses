namespace HerhalingsOefeningJarrikVanCampLuchthaven
{
    partial class frmFlightManagement
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
            this.lstCrew = new System.Windows.Forms.ListBox();
            this.lstPilots = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVluchtnummer = new System.Windows.Forms.TextBox();
            this.cbDeparture = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtTakeOffTime = new System.Windows.Forms.DateTimePicker();
            this.cbAirplane = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstCrew
            // 
            this.lstCrew.FormattingEnabled = true;
            this.lstCrew.Location = new System.Drawing.Point(196, 315);
            this.lstCrew.Name = "lstCrew";
            this.lstCrew.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCrew.Size = new System.Drawing.Size(286, 134);
            this.lstCrew.TabIndex = 0;
            // 
            // lstPilots
            // 
            this.lstPilots.FormattingEnabled = true;
            this.lstPilots.Location = new System.Drawing.Point(196, 175);
            this.lstPilots.Name = "lstPilots";
            this.lstPilots.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPilots.Size = new System.Drawing.Size(286, 134);
            this.lstPilots.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(275, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(388, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pilots for flight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crew for Flight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departure date & time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vluchtnummer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Departure";
            // 
            // txtVluchtnummer
            // 
            this.txtVluchtnummer.Location = new System.Drawing.Point(196, 25);
            this.txtVluchtnummer.Name = "txtVluchtnummer";
            this.txtVluchtnummer.Size = new System.Drawing.Size(154, 20);
            this.txtVluchtnummer.TabIndex = 11;
            // 
            // cbDeparture
            // 
            this.cbDeparture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeparture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDeparture.FormattingEnabled = true;
            this.cbDeparture.Location = new System.Drawing.Point(196, 53);
            this.cbDeparture.Name = "cbDeparture";
            this.cbDeparture.Size = new System.Drawing.Size(286, 21);
            this.cbDeparture.TabIndex = 12;
            // 
            // cbDestination
            // 
            this.cbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(196, 80);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(286, 21);
            this.cbDestination.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aircraft";
            // 
            // dtTakeOffTime
            // 
            this.dtTakeOffTime.CustomFormat = "dd / MM / yyyy -- HH : mm";
            this.dtTakeOffTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTakeOffTime.Location = new System.Drawing.Point(196, 107);
            this.dtTakeOffTime.Name = "dtTakeOffTime";
            this.dtTakeOffTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtTakeOffTime.Size = new System.Drawing.Size(154, 20);
            this.dtTakeOffTime.TabIndex = 15;
            this.dtTakeOffTime.Value = new System.DateTime(2015, 10, 11, 12, 33, 0, 0);
            // 
            // cbAirplane
            // 
            this.cbAirplane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirplane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAirplane.FormattingEnabled = true;
            this.cbAirplane.Location = new System.Drawing.Point(196, 137);
            this.cbAirplane.Name = "cbAirplane";
            this.cbAirplane.Size = new System.Drawing.Size(286, 21);
            this.cbAirplane.TabIndex = 16;
            // 
            // frmFlightManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 500);
            this.Controls.Add(this.cbAirplane);
            this.Controls.Add(this.dtTakeOffTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.cbDeparture);
            this.Controls.Add(this.txtVluchtnummer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstPilots);
            this.Controls.Add(this.lstCrew);
            this.Name = "frmFlightManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCrew;
        private System.Windows.Forms.ListBox lstPilots;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVluchtnummer;
        private System.Windows.Forms.ComboBox cbDeparture;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtTakeOffTime;
        private System.Windows.Forms.ComboBox cbAirplane;
    }
}