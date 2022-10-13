namespace SplatInk.Forms
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
            this.tcpGeckoConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.wiiUIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.changeInkColourButton = new System.Windows.Forms.Button();
            this.tcpGeckoConnectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcpGeckoConnectionGroupBox
            // 
            this.tcpGeckoConnectionGroupBox.Controls.Add(this.connectionStatusLabel);
            this.tcpGeckoConnectionGroupBox.Controls.Add(this.wiiUIPAddressTextBox);
            this.tcpGeckoConnectionGroupBox.Controls.Add(this.disconnectButton);
            this.tcpGeckoConnectionGroupBox.Controls.Add(this.connectButton);
            this.tcpGeckoConnectionGroupBox.Controls.Add(this.label1);
            this.tcpGeckoConnectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpGeckoConnectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.tcpGeckoConnectionGroupBox.Name = "tcpGeckoConnectionGroupBox";
            this.tcpGeckoConnectionGroupBox.Size = new System.Drawing.Size(519, 87);
            this.tcpGeckoConnectionGroupBox.TabIndex = 0;
            this.tcpGeckoConnectionGroupBox.TabStop = false;
            this.tcpGeckoConnectionGroupBox.Text = "TCPGecko Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wii U IP Address:";
            // 
            // connectButton
            // 
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectButton.Location = new System.Drawing.Point(314, 27);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(87, 24);
            this.connectButton.TabIndex = 1;
            this.connectButton.TabStop = false;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.disconnectButton.Location = new System.Drawing.Point(407, 27);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(91, 24);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.TabStop = false;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            // 
            // wiiUIPAddressTextBox
            // 
            this.wiiUIPAddressTextBox.BackColor = System.Drawing.Color.Red;
            this.wiiUIPAddressTextBox.Location = new System.Drawing.Point(132, 30);
            this.wiiUIPAddressTextBox.Name = "wiiUIPAddressTextBox";
            this.wiiUIPAddressTextBox.Size = new System.Drawing.Size(167, 20);
            this.wiiUIPAddressTextBox.TabIndex = 3;
            this.wiiUIPAddressTextBox.TabStop = false;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionStatusLabel.Location = new System.Drawing.Point(145, 60);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(231, 16);
            this.connectionStatusLabel.TabIndex = 4;
            this.connectionStatusLabel.Text = "Connection Status: Not Connected";
            this.connectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeInkColourButton
            // 
            this.changeInkColourButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeInkColourButton.Location = new System.Drawing.Point(12, 116);
            this.changeInkColourButton.Name = "changeInkColourButton";
            this.changeInkColourButton.Size = new System.Drawing.Size(519, 25);
            this.changeInkColourButton.TabIndex = 1;
            this.changeInkColourButton.TabStop = false;
            this.changeInkColourButton.Text = "Change Ink Colour!";
            this.changeInkColourButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 154);
            this.Controls.Add(this.changeInkColourButton);
            this.Controls.Add(this.tcpGeckoConnectionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplatInk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcpGeckoConnectionGroupBox.ResumeLayout(false);
            this.tcpGeckoConnectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tcpGeckoConnectionGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox wiiUIPAddressTextBox;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Button changeInkColourButton;
    }
}

