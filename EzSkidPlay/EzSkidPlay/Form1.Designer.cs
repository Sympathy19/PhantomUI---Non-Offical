namespace EzSkidPlay
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtServer1 = new System.Windows.Forms.TextBox();
            this.txtPort1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.PanelAddServer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnSaveServer = new System.Windows.Forms.Button();
            this.PanelExistingServer = new System.Windows.Forms.Panel();
            this.ListServers = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rdUseExisting = new System.Windows.Forms.RadioButton();
            this.rdAddServer = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.ExistingServerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PanelBase.SuspendLayout();
            this.PanelAddServer.SuspendLayout();
            this.PanelExistingServer.SuspendLayout();
            this.ExistingServerContextMenu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServer1
            // 
            this.txtServer1.Location = new System.Drawing.Point(6, 30);
            this.txtServer1.Name = "txtServer1";
            this.txtServer1.Size = new System.Drawing.Size(285, 25);
            this.txtServer1.TabIndex = 0;
            // 
            // txtPort1
            // 
            this.txtPort1.Location = new System.Drawing.Point(6, 82);
            this.txtPort1.Name = "txtPort1";
            this.txtPort1.Size = new System.Drawing.Size(285, 25);
            this.txtPort1.TabIndex = 1;
            this.txtPort1.Text = "19132";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 112);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(285, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Phantom";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Port";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 207);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtServer1);
            this.tabPage1.Controls.Add(this.txtPort1);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 177);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Made by ItzSympathy";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.PanelBase);
            this.tabPage2.Controls.Add(this.rdUseExisting);
            this.tabPage2.Controls.Add(this.rdAddServer);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(301, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custom Servers";
            // 
            // PanelBase
            // 
            this.PanelBase.Controls.Add(this.PanelAddServer);
            this.PanelBase.Controls.Add(this.PanelExistingServer);
            this.PanelBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBase.Location = new System.Drawing.Point(3, 45);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(295, 294);
            this.PanelBase.TabIndex = 2;
            // 
            // PanelAddServer
            // 
            this.PanelAddServer.Controls.Add(this.label9);
            this.PanelAddServer.Controls.Add(this.txtServerName);
            this.PanelAddServer.Controls.Add(this.label8);
            this.PanelAddServer.Controls.Add(this.label7);
            this.PanelAddServer.Controls.Add(this.label6);
            this.PanelAddServer.Controls.Add(this.label4);
            this.PanelAddServer.Controls.Add(this.label5);
            this.PanelAddServer.Controls.Add(this.txtServerIP);
            this.PanelAddServer.Controls.Add(this.txtPort);
            this.PanelAddServer.Controls.Add(this.btnSaveServer);
            this.PanelAddServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAddServer.Location = new System.Drawing.Point(0, 0);
            this.PanelAddServer.Name = "PanelAddServer";
            this.PanelAddServer.Size = new System.Drawing.Size(295, 294);
            this.PanelAddServer.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Minecraft Uses the port 19132 by default!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Are Correct for each Server!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Make sure the IP and Ports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Server Port";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(5, 82);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(285, 25);
            this.txtServerIP.TabIndex = 5;
            this.txtServerIP.Text = "\r\nIP Address or Hostname here";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(5, 134);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(285, 25);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "19132";
            // 
            // btnSaveServer
            // 
            this.btnSaveServer.Location = new System.Drawing.Point(5, 164);
            this.btnSaveServer.Name = "btnSaveServer";
            this.btnSaveServer.Size = new System.Drawing.Size(285, 35);
            this.btnSaveServer.TabIndex = 7;
            this.btnSaveServer.Text = "Save Server!";
            this.btnSaveServer.UseVisualStyleBackColor = true;
            this.btnSaveServer.Click += new System.EventHandler(this.btnSaveServer_Click);
            // 
            // PanelExistingServer
            // 
            this.PanelExistingServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelExistingServer.Controls.Add(this.ListServers);
            this.PanelExistingServer.Controls.Add(this.btnConnect);
            this.PanelExistingServer.Location = new System.Drawing.Point(0, 0);
            this.PanelExistingServer.Name = "PanelExistingServer";
            this.PanelExistingServer.Size = new System.Drawing.Size(295, 294);
            this.PanelExistingServer.TabIndex = 1;
            // 
            // ListServers
            // 
            this.ListServers.FormattingEnabled = true;
            this.ListServers.ItemHeight = 17;
            this.ListServers.Location = new System.Drawing.Point(6, 14);
            this.ListServers.Name = "ListServers";
            this.ListServers.Size = new System.Drawing.Size(284, 225);
            this.ListServers.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnConnect.FlatAppearance.BorderSize = 10;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Location = new System.Drawing.Point(6, 246);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(284, 43);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Attempt Connection!";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rdUseExisting
            // 
            this.rdUseExisting.AutoSize = true;
            this.rdUseExisting.Location = new System.Drawing.Point(162, 18);
            this.rdUseExisting.Name = "rdUseExisting";
            this.rdUseExisting.Size = new System.Drawing.Size(100, 21);
            this.rdUseExisting.TabIndex = 1;
            this.rdUseExisting.Text = "Use Existing";
            this.rdUseExisting.UseVisualStyleBackColor = true;
            this.rdUseExisting.CheckedChanged += new System.EventHandler(this.rdUseExisting_CheckedChanged);
            // 
            // rdAddServer
            // 
            this.rdAddServer.AutoSize = true;
            this.rdAddServer.Checked = true;
            this.rdAddServer.Location = new System.Drawing.Point(42, 18);
            this.rdAddServer.Name = "rdAddServer";
            this.rdAddServer.Size = new System.Drawing.Size(94, 21);
            this.rdAddServer.TabIndex = 0;
            this.rdAddServer.TabStop = true;
            this.rdAddServer.Text = "Add Server";
            this.rdAddServer.UseVisualStyleBackColor = true;
            this.rdAddServer.CheckedChanged += new System.EventHandler(this.rdAddServer_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Server Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(5, 30);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(285, 25);
            this.txtServerName.TabIndex = 13;
            this.txtServerName.Text = "Custom Minecraft Server";
            // 
            // ExistingServerContextMenu
            // 
            this.ExistingServerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeServerToolStripMenuItem});
            this.ExistingServerContextMenu.Name = "ExistingServerContextMenu";
            this.ExistingServerContextMenu.Size = new System.Drawing.Size(200, 26);
            // 
            // removeServerToolStripMenuItem
            // 
            this.removeServerToolStripMenuItem.Name = "removeServerToolStripMenuItem";
            this.removeServerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.removeServerToolStripMenuItem.Text = "Remove Selected Server";
            this.removeServerToolStripMenuItem.Click += new System.EventHandler(this.removeServerToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.linkLabel2);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(301, 177);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(137, 153);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 21);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get More Servers";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(17, 153);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(104, 21);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Our Discord";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(294, 146);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 207);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Welcome To PhantomUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PanelBase.ResumeLayout(false);
            this.PanelAddServer.ResumeLayout(false);
            this.PanelAddServer.PerformLayout();
            this.PanelExistingServer.ResumeLayout(false);
            this.ExistingServerContextMenu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer1;
        private System.Windows.Forms.TextBox txtPort1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.Panel PanelExistingServer;
        private System.Windows.Forms.Panel PanelAddServer;
        private System.Windows.Forms.RadioButton rdUseExisting;
        private System.Windows.Forms.RadioButton rdAddServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox ListServers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnSaveServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.ContextMenuStrip ExistingServerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeServerToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

