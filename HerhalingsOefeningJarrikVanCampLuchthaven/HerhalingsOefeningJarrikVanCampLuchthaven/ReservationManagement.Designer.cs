namespace HerhalingsOefeningJarrikVanCampLuchthaven
{
    partial class frmReservationManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstPassengers = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtVluchtnummer = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtMaxNumberOfPassengers = new System.Windows.Forms.TextBox();
            this.txtCurrentReservations = new System.Windows.Forms.TextBox();
            this.txtAirplane = new System.Windows.Forms.TextBox();
            this.dtTakeOffTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vluchtnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Take-off Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Airplane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max Number of Passengers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Current Number of Reservations";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Passenger(s)";
            // 
            // lstPassengers
            // 
            this.lstPassengers.FormattingEnabled = true;
            this.lstPassengers.Location = new System.Drawing.Point(178, 251);
            this.lstPassengers.Name = "lstPassengers";
            this.lstPassengers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstPassengers.Size = new System.Drawing.Size(265, 199);
            this.lstPassengers.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(349, 459);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtVluchtnummer
            // 
            this.txtVluchtnummer.Enabled = false;
            this.txtVluchtnummer.Location = new System.Drawing.Point(178, 17);
            this.txtVluchtnummer.Name = "txtVluchtnummer";
            this.txtVluchtnummer.Size = new System.Drawing.Size(100, 20);
            this.txtVluchtnummer.TabIndex = 11;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Enabled = false;
            this.txtDeparture.Location = new System.Drawing.Point(178, 48);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(265, 20);
            this.txtDeparture.TabIndex = 12;
            // 
            // txtDestination
            // 
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(178, 83);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(265, 20);
            this.txtDestination.TabIndex = 13;
            // 
            // txtMaxNumberOfPassengers
            // 
            this.txtMaxNumberOfPassengers.Enabled = false;
            this.txtMaxNumberOfPassengers.Location = new System.Drawing.Point(178, 184);
            this.txtMaxNumberOfPassengers.Name = "txtMaxNumberOfPassengers";
            this.txtMaxNumberOfPassengers.Size = new System.Drawing.Size(265, 20);
            this.txtMaxNumberOfPassengers.TabIndex = 14;
            // 
            // txtCurrentReservations
            // 
            this.txtCurrentReservations.Enabled = false;
            this.txtCurrentReservations.Location = new System.Drawing.Point(178, 213);
            this.txtCurrentReservations.Name = "txtCurrentReservations";
            this.txtCurrentReservations.Size = new System.Drawing.Size(265, 20);
            this.txtCurrentReservations.TabIndex = 15;
            // 
            // txtAirplane
            // 
            this.txtAirplane.Enabled = false;
            this.txtAirplane.Location = new System.Drawing.Point(178, 149);
            this.txtAirplane.Name = "txtAirplane";
            this.txtAirplane.Size = new System.Drawing.Size(265, 20);
            this.txtAirplane.TabIndex = 16;
            // 
            // dtTakeOffTime
            // 
            this.dtTakeOffTime.Enabled = false;
            this.dtTakeOffTime.Location = new System.Drawing.Point(178, 116);
            this.dtTakeOffTime.Name = "dtTakeOffTime";
            this.dtTakeOffTime.Size = new System.Drawing.Size(200, 20);
            this.dtTakeOffTime.TabIndex = 17;
            // 
            // frmReservationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 494);
            this.Controls.Add(this.dtTakeOffTime);
            this.Controls.Add(this.txtAirplane);
            this.Controls.Add(this.txtCurrentReservations);
            this.Controls.Add(this.txtMaxNumberOfPassengers);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.txtVluchtnummer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstPassengers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReservationManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstPassengers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtVluchtnummer;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtMaxNumberOfPassengers;
        private System.Windows.Forms.TextBox txtCurrentReservations;
        private System.Windows.Forms.TextBox txtAirplane;
        private System.Windows.Forms.DateTimePicker dtTakeOffTime;
    }
}