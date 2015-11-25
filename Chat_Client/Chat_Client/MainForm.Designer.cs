namespace Chat_Client
{
    partial class FrmMain
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
            this.grpClient1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPortClient1 = new System.Windows.Forms.TextBox();
            this.txtIpClient1 = new System.Windows.Forms.TextBox();
            this.grpClient2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortClient2 = new System.Windows.Forms.TextBox();
            this.txtIpClient2 = new System.Windows.Forms.TextBox();
            this.txtMessageWriter = new System.Windows.Forms.TextBox();
            this.lstChatbox = new System.Windows.Forms.ListBox();
            this.btnConnectClients = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.grpClient1.SuspendLayout();
            this.grpClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClient1
            // 
            this.grpClient1.Controls.Add(this.label2);
            this.grpClient1.Controls.Add(this.label1);
            this.grpClient1.Controls.Add(this.txtPortClient1);
            this.grpClient1.Controls.Add(this.txtIpClient1);
            this.grpClient1.Location = new System.Drawing.Point(12, 12);
            this.grpClient1.Name = "grpClient1";
            this.grpClient1.Size = new System.Drawing.Size(319, 125);
            this.grpClient1.TabIndex = 0;
            this.grpClient1.TabStop = false;
            this.grpClient1.Text = "Client 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // txtPortClient1
            // 
            this.txtPortClient1.Location = new System.Drawing.Point(150, 83);
            this.txtPortClient1.Name = "txtPortClient1";
            this.txtPortClient1.Size = new System.Drawing.Size(163, 20);
            this.txtPortClient1.TabIndex = 1;
            // 
            // txtIpClient1
            // 
            this.txtIpClient1.Location = new System.Drawing.Point(150, 40);
            this.txtIpClient1.Name = "txtIpClient1";
            this.txtIpClient1.Size = new System.Drawing.Size(163, 20);
            this.txtIpClient1.TabIndex = 0;
            // 
            // grpClient2
            // 
            this.grpClient2.Controls.Add(this.label3);
            this.grpClient2.Controls.Add(this.label4);
            this.grpClient2.Controls.Add(this.txtPortClient2);
            this.grpClient2.Controls.Add(this.txtIpClient2);
            this.grpClient2.Location = new System.Drawing.Point(367, 12);
            this.grpClient2.Name = "grpClient2";
            this.grpClient2.Size = new System.Drawing.Size(319, 125);
            this.grpClient2.TabIndex = 1;
            this.grpClient2.TabStop = false;
            this.grpClient2.Text = "Client2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP";
            // 
            // txtPortClient2
            // 
            this.txtPortClient2.Location = new System.Drawing.Point(150, 83);
            this.txtPortClient2.Name = "txtPortClient2";
            this.txtPortClient2.Size = new System.Drawing.Size(163, 20);
            this.txtPortClient2.TabIndex = 3;
            // 
            // txtIpClient2
            // 
            this.txtIpClient2.Location = new System.Drawing.Point(150, 40);
            this.txtIpClient2.Name = "txtIpClient2";
            this.txtIpClient2.Size = new System.Drawing.Size(163, 20);
            this.txtIpClient2.TabIndex = 2;
            // 
            // txtMessageWriter
            // 
            this.txtMessageWriter.Location = new System.Drawing.Point(12, 494);
            this.txtMessageWriter.Name = "txtMessageWriter";
            this.txtMessageWriter.Size = new System.Drawing.Size(532, 20);
            this.txtMessageWriter.TabIndex = 2;
            // 
            // lstChatbox
            // 
            this.lstChatbox.FormattingEnabled = true;
            this.lstChatbox.Location = new System.Drawing.Point(12, 148);
            this.lstChatbox.Name = "lstChatbox";
            this.lstChatbox.Size = new System.Drawing.Size(532, 329);
            this.lstChatbox.TabIndex = 3;
            // 
            // btnConnectClients
            // 
            this.btnConnectClients.Location = new System.Drawing.Point(556, 148);
            this.btnConnectClients.Name = "btnConnectClients";
            this.btnConnectClients.Size = new System.Drawing.Size(130, 23);
            this.btnConnectClients.TabIndex = 4;
            this.btnConnectClients.Text = "Connect";
            this.btnConnectClients.UseVisualStyleBackColor = true;
            this.btnConnectClients.Click += new System.EventHandler(this.btnConnectClients_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Enabled = false;
            this.btnSendMessage.Location = new System.Drawing.Point(556, 491);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(130, 23);
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 537);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnConnectClients);
            this.Controls.Add(this.lstChatbox);
            this.Controls.Add(this.txtMessageWriter);
            this.Controls.Add(this.grpClient2);
            this.Controls.Add(this.grpClient1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatClient";
            this.grpClient1.ResumeLayout(false);
            this.grpClient1.PerformLayout();
            this.grpClient2.ResumeLayout(false);
            this.grpClient2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClient1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPortClient1;
        private System.Windows.Forms.TextBox txtIpClient1;
        private System.Windows.Forms.GroupBox grpClient2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortClient2;
        private System.Windows.Forms.TextBox txtIpClient2;
        private System.Windows.Forms.TextBox txtMessageWriter;
        private System.Windows.Forms.ListBox lstChatbox;
        private System.Windows.Forms.Button btnConnectClients;
        private System.Windows.Forms.Button btnSendMessage;
    }
}

