namespace HerhalingsOefeningJarrikVanCampLuchthaven
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
            this.grpPersoneel = new System.Windows.Forms.GroupBox();
            this.btnWijzigenPersoneel = new System.Windows.Forms.Button();
            this.btnVerwijderenPersoneel = new System.Windows.Forms.Button();
            this.btnToevoegenPersoneel = new System.Windows.Forms.Button();
            this.lstPersoneel = new System.Windows.Forms.ListBox();
            this.grpVluchten = new System.Windows.Forms.GroupBox();
            this.btnReservatieMaken = new System.Windows.Forms.Button();
            this.btnVerwijderVlucht = new System.Windows.Forms.Button();
            this.btnWijzigenVlucht = new System.Windows.Forms.Button();
            this.btnToevoegenVlucht = new System.Windows.Forms.Button();
            this.lstVluchten = new System.Windows.Forms.ListBox();
            this.grpPassagiers = new System.Windows.Forms.GroupBox();
            this.btnVerwijderenPassagiers = new System.Windows.Forms.Button();
            this.btnWijzigenPassagier = new System.Windows.Forms.Button();
            this.btnToevoegenPassagier = new System.Windows.Forms.Button();
            this.lstPassagiers = new System.Windows.Forms.ListBox();
            this.grpLuchthaven = new System.Windows.Forms.GroupBox();
            this.btnVerwijderLuchthaven = new System.Windows.Forms.Button();
            this.btnWijzigenLuchthaven = new System.Windows.Forms.Button();
            this.btnToevoegenLuchthaven = new System.Windows.Forms.Button();
            this.lstLuchthaven = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstPassagiersVanVlucht = new System.Windows.Forms.ListBox();
            this.grpPersoneel.SuspendLayout();
            this.grpVluchten.SuspendLayout();
            this.grpPassagiers.SuspendLayout();
            this.grpLuchthaven.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersoneel
            // 
            this.grpPersoneel.Controls.Add(this.btnWijzigenPersoneel);
            this.grpPersoneel.Controls.Add(this.btnVerwijderenPersoneel);
            this.grpPersoneel.Controls.Add(this.btnToevoegenPersoneel);
            this.grpPersoneel.Controls.Add(this.lstPersoneel);
            this.grpPersoneel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersoneel.Location = new System.Drawing.Point(12, 12);
            this.grpPersoneel.Name = "grpPersoneel";
            this.grpPersoneel.Size = new System.Drawing.Size(474, 238);
            this.grpPersoneel.TabIndex = 0;
            this.grpPersoneel.TabStop = false;
            this.grpPersoneel.Text = "Beheer piloten  & cabinepersoneel";
            // 
            // btnWijzigenPersoneel
            // 
            this.btnWijzigenPersoneel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigenPersoneel.Location = new System.Drawing.Point(312, 208);
            this.btnWijzigenPersoneel.Name = "btnWijzigenPersoneel";
            this.btnWijzigenPersoneel.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenPersoneel.TabIndex = 3;
            this.btnWijzigenPersoneel.Text = "Wijzigen";
            this.btnWijzigenPersoneel.UseVisualStyleBackColor = true;
            this.btnWijzigenPersoneel.Click += new System.EventHandler(this.btnWijzigenPersoneel_Click);
            // 
            // btnVerwijderenPersoneel
            // 
            this.btnVerwijderenPersoneel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderenPersoneel.Location = new System.Drawing.Point(393, 208);
            this.btnVerwijderenPersoneel.Name = "btnVerwijderenPersoneel";
            this.btnVerwijderenPersoneel.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderenPersoneel.TabIndex = 2;
            this.btnVerwijderenPersoneel.Text = "Verwijderen";
            this.btnVerwijderenPersoneel.UseVisualStyleBackColor = true;
            this.btnVerwijderenPersoneel.Click += new System.EventHandler(this.btnVerwijderenPersoneel_Click);
            // 
            // btnToevoegenPersoneel
            // 
            this.btnToevoegenPersoneel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegenPersoneel.Location = new System.Drawing.Point(231, 208);
            this.btnToevoegenPersoneel.Name = "btnToevoegenPersoneel";
            this.btnToevoegenPersoneel.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegenPersoneel.TabIndex = 1;
            this.btnToevoegenPersoneel.Text = "Toevoegen";
            this.btnToevoegenPersoneel.UseVisualStyleBackColor = true;
            this.btnToevoegenPersoneel.Click += new System.EventHandler(this.btnToevoegenPersoneel_Click);
            // 
            // lstPersoneel
            // 
            this.lstPersoneel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPersoneel.FormattingEnabled = true;
            this.lstPersoneel.Location = new System.Drawing.Point(6, 22);
            this.lstPersoneel.Name = "lstPersoneel";
            this.lstPersoneel.Size = new System.Drawing.Size(462, 173);
            this.lstPersoneel.TabIndex = 0;
            // 
            // grpVluchten
            // 
            this.grpVluchten.Controls.Add(this.btnReservatieMaken);
            this.grpVluchten.Controls.Add(this.btnVerwijderVlucht);
            this.grpVluchten.Controls.Add(this.btnWijzigenVlucht);
            this.grpVluchten.Controls.Add(this.btnToevoegenVlucht);
            this.grpVluchten.Controls.Add(this.lstVluchten);
            this.grpVluchten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVluchten.Location = new System.Drawing.Point(12, 256);
            this.grpVluchten.Name = "grpVluchten";
            this.grpVluchten.Size = new System.Drawing.Size(687, 242);
            this.grpVluchten.TabIndex = 1;
            this.grpVluchten.TabStop = false;
            this.grpVluchten.Text = "Beheer Vluchten";
            // 
            // btnReservatieMaken
            // 
            this.btnReservatieMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservatieMaken.Location = new System.Drawing.Point(6, 208);
            this.btnReservatieMaken.Name = "btnReservatieMaken";
            this.btnReservatieMaken.Size = new System.Drawing.Size(120, 23);
            this.btnReservatieMaken.TabIndex = 8;
            this.btnReservatieMaken.Text = "Reservatie";
            this.btnReservatieMaken.UseVisualStyleBackColor = true;
            this.btnReservatieMaken.Click += new System.EventHandler(this.btnReservatieMaken_Click);
            // 
            // btnVerwijderVlucht
            // 
            this.btnVerwijderVlucht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderVlucht.Location = new System.Drawing.Point(607, 208);
            this.btnVerwijderVlucht.Name = "btnVerwijderVlucht";
            this.btnVerwijderVlucht.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderVlucht.TabIndex = 7;
            this.btnVerwijderVlucht.Text = "Verwijderen";
            this.btnVerwijderVlucht.UseVisualStyleBackColor = true;
            this.btnVerwijderVlucht.Click += new System.EventHandler(this.btnVerwijderVlucht_Click);
            // 
            // btnWijzigenVlucht
            // 
            this.btnWijzigenVlucht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigenVlucht.Location = new System.Drawing.Point(526, 208);
            this.btnWijzigenVlucht.Name = "btnWijzigenVlucht";
            this.btnWijzigenVlucht.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenVlucht.TabIndex = 6;
            this.btnWijzigenVlucht.Text = "Wijzigen";
            this.btnWijzigenVlucht.UseVisualStyleBackColor = true;
            this.btnWijzigenVlucht.Click += new System.EventHandler(this.btnWijzigenVlucht_Click);
            // 
            // btnToevoegenVlucht
            // 
            this.btnToevoegenVlucht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegenVlucht.Location = new System.Drawing.Point(445, 208);
            this.btnToevoegenVlucht.Name = "btnToevoegenVlucht";
            this.btnToevoegenVlucht.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegenVlucht.TabIndex = 5;
            this.btnToevoegenVlucht.Text = "Toevoegen";
            this.btnToevoegenVlucht.UseVisualStyleBackColor = true;
            this.btnToevoegenVlucht.Click += new System.EventHandler(this.btnToevoegenVlucht_Click);
            // 
            // lstVluchten
            // 
            this.lstVluchten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVluchten.FormattingEnabled = true;
            this.lstVluchten.Location = new System.Drawing.Point(6, 22);
            this.lstVluchten.Name = "lstVluchten";
            this.lstVluchten.Size = new System.Drawing.Size(676, 173);
            this.lstVluchten.TabIndex = 4;
            this.lstVluchten.SelectedIndexChanged += new System.EventHandler(this.lstVluchten_SelectedIndexChanged);
            // 
            // grpPassagiers
            // 
            this.grpPassagiers.Controls.Add(this.btnVerwijderenPassagiers);
            this.grpPassagiers.Controls.Add(this.btnWijzigenPassagier);
            this.grpPassagiers.Controls.Add(this.btnToevoegenPassagier);
            this.grpPassagiers.Controls.Add(this.lstPassagiers);
            this.grpPassagiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPassagiers.Location = new System.Drawing.Point(492, 12);
            this.grpPassagiers.Name = "grpPassagiers";
            this.grpPassagiers.Size = new System.Drawing.Size(266, 238);
            this.grpPassagiers.TabIndex = 4;
            this.grpPassagiers.TabStop = false;
            this.grpPassagiers.Text = "Beheer Passagiers";
            // 
            // btnVerwijderenPassagiers
            // 
            this.btnVerwijderenPassagiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderenPassagiers.Location = new System.Drawing.Point(180, 208);
            this.btnVerwijderenPassagiers.Name = "btnVerwijderenPassagiers";
            this.btnVerwijderenPassagiers.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderenPassagiers.TabIndex = 3;
            this.btnVerwijderenPassagiers.Text = "Verwijderen";
            this.btnVerwijderenPassagiers.UseVisualStyleBackColor = true;
            this.btnVerwijderenPassagiers.Click += new System.EventHandler(this.btnVerwijderenPassagiers_Click);
            // 
            // btnWijzigenPassagier
            // 
            this.btnWijzigenPassagier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigenPassagier.Location = new System.Drawing.Point(99, 208);
            this.btnWijzigenPassagier.Name = "btnWijzigenPassagier";
            this.btnWijzigenPassagier.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenPassagier.TabIndex = 2;
            this.btnWijzigenPassagier.Text = "Wijzigen";
            this.btnWijzigenPassagier.UseVisualStyleBackColor = true;
            this.btnWijzigenPassagier.Click += new System.EventHandler(this.btnWijzigenPassagier_Click);
            // 
            // btnToevoegenPassagier
            // 
            this.btnToevoegenPassagier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegenPassagier.Location = new System.Drawing.Point(18, 208);
            this.btnToevoegenPassagier.Name = "btnToevoegenPassagier";
            this.btnToevoegenPassagier.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegenPassagier.TabIndex = 1;
            this.btnToevoegenPassagier.Text = "Toevoegen";
            this.btnToevoegenPassagier.UseVisualStyleBackColor = true;
            this.btnToevoegenPassagier.Click += new System.EventHandler(this.btnToevoegenPassagier_Click);
            // 
            // lstPassagiers
            // 
            this.lstPassagiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPassagiers.FormattingEnabled = true;
            this.lstPassagiers.Location = new System.Drawing.Point(6, 22);
            this.lstPassagiers.Name = "lstPassagiers";
            this.lstPassagiers.Size = new System.Drawing.Size(252, 173);
            this.lstPassagiers.TabIndex = 0;
            // 
            // grpLuchthaven
            // 
            this.grpLuchthaven.Controls.Add(this.btnVerwijderLuchthaven);
            this.grpLuchthaven.Controls.Add(this.btnWijzigenLuchthaven);
            this.grpLuchthaven.Controls.Add(this.btnToevoegenLuchthaven);
            this.grpLuchthaven.Controls.Add(this.lstLuchthaven);
            this.grpLuchthaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLuchthaven.Location = new System.Drawing.Point(764, 12);
            this.grpLuchthaven.Name = "grpLuchthaven";
            this.grpLuchthaven.Size = new System.Drawing.Size(266, 238);
            this.grpLuchthaven.TabIndex = 5;
            this.grpLuchthaven.TabStop = false;
            this.grpLuchthaven.Text = "Beheer Luchthavens";
            // 
            // btnVerwijderLuchthaven
            // 
            this.btnVerwijderLuchthaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderLuchthaven.Location = new System.Drawing.Point(180, 208);
            this.btnVerwijderLuchthaven.Name = "btnVerwijderLuchthaven";
            this.btnVerwijderLuchthaven.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderLuchthaven.TabIndex = 3;
            this.btnVerwijderLuchthaven.Text = "Verwijderen";
            this.btnVerwijderLuchthaven.UseVisualStyleBackColor = true;
            this.btnVerwijderLuchthaven.Click += new System.EventHandler(this.btnVerwijderLuchthaven_Click);
            // 
            // btnWijzigenLuchthaven
            // 
            this.btnWijzigenLuchthaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigenLuchthaven.Location = new System.Drawing.Point(99, 208);
            this.btnWijzigenLuchthaven.Name = "btnWijzigenLuchthaven";
            this.btnWijzigenLuchthaven.Size = new System.Drawing.Size(75, 23);
            this.btnWijzigenLuchthaven.TabIndex = 2;
            this.btnWijzigenLuchthaven.Text = "Wijzigen";
            this.btnWijzigenLuchthaven.UseVisualStyleBackColor = true;
            this.btnWijzigenLuchthaven.Click += new System.EventHandler(this.btnWijzigenLuchthaven_Click);
            // 
            // btnToevoegenLuchthaven
            // 
            this.btnToevoegenLuchthaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegenLuchthaven.Location = new System.Drawing.Point(18, 208);
            this.btnToevoegenLuchthaven.Name = "btnToevoegenLuchthaven";
            this.btnToevoegenLuchthaven.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegenLuchthaven.TabIndex = 1;
            this.btnToevoegenLuchthaven.Text = "Toevoegen";
            this.btnToevoegenLuchthaven.UseVisualStyleBackColor = true;
            this.btnToevoegenLuchthaven.Click += new System.EventHandler(this.btnToevoegenLuchthaven_Click);
            // 
            // lstLuchthaven
            // 
            this.lstLuchthaven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLuchthaven.FormattingEnabled = true;
            this.lstLuchthaven.Location = new System.Drawing.Point(6, 22);
            this.lstLuchthaven.Name = "lstLuchthaven";
            this.lstLuchthaven.Size = new System.Drawing.Size(252, 173);
            this.lstLuchthaven.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstPassagiersVanVlucht);
            this.groupBox4.Location = new System.Drawing.Point(705, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 242);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OverzichtReservatiesPerVlucht";
            // 
            // lstPassagiersVanVlucht
            // 
            this.lstPassagiersVanVlucht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPassagiersVanVlucht.FormattingEnabled = true;
            this.lstPassagiersVanVlucht.Location = new System.Drawing.Point(6, 22);
            this.lstPassagiersVanVlucht.Name = "lstPassagiersVanVlucht";
            this.lstPassagiersVanVlucht.Size = new System.Drawing.Size(308, 212);
            this.lstPassagiersVanVlucht.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpLuchthaven);
            this.Controls.Add(this.grpPassagiers);
            this.Controls.Add(this.grpVluchten);
            this.Controls.Add(this.grpPersoneel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luchthaven";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpPersoneel.ResumeLayout(false);
            this.grpVluchten.ResumeLayout(false);
            this.grpPassagiers.ResumeLayout(false);
            this.grpLuchthaven.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersoneel;
        private System.Windows.Forms.GroupBox grpVluchten;
        private System.Windows.Forms.Button btnWijzigenPersoneel;
        private System.Windows.Forms.Button btnVerwijderenPersoneel;
        private System.Windows.Forms.Button btnToevoegenPersoneel;
        private System.Windows.Forms.ListBox lstPersoneel;
        private System.Windows.Forms.Button btnVerwijderVlucht;
        private System.Windows.Forms.Button btnWijzigenVlucht;
        private System.Windows.Forms.Button btnToevoegenVlucht;
        private System.Windows.Forms.ListBox lstVluchten;
        private System.Windows.Forms.GroupBox grpPassagiers;
        private System.Windows.Forms.Button btnVerwijderenPassagiers;
        private System.Windows.Forms.Button btnWijzigenPassagier;
        private System.Windows.Forms.Button btnToevoegenPassagier;
        private System.Windows.Forms.ListBox lstPassagiers;
        private System.Windows.Forms.GroupBox grpLuchthaven;
        private System.Windows.Forms.Button btnVerwijderLuchthaven;
        private System.Windows.Forms.Button btnWijzigenLuchthaven;
        private System.Windows.Forms.Button btnToevoegenLuchthaven;
        private System.Windows.Forms.ListBox lstLuchthaven;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReservatieMaken;
        private System.Windows.Forms.ListBox lstPassagiersVanVlucht;
    }
}

