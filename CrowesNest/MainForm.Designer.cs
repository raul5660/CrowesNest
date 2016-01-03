namespace CrowesNest
{
    partial class CrowesNest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrowesNest));
            this.Run = new System.Windows.Forms.Button();
            this.SyntaxTextBox = new System.Windows.Forms.RichTextBox();
            this.ToolLabel = new System.Windows.Forms.Label();
            this.SyntaxLabel = new System.Windows.Forms.Label();
            this.ToolsListBox = new System.Windows.Forms.ListBox();
            this.ClientButton = new System.Windows.Forms.Button();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.Button();
            this.MultiHostCheckBox = new System.Windows.Forms.CheckBox();
            this.HostsButton = new System.Windows.Forms.Button();
            this.HostsTextBox = new System.Windows.Forms.TextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.OSValueLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.RichTextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ScpButton = new System.Windows.Forms.Button();
            this.ToolGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoteGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolGroupBox.SuspendLayout();
            this.RemoteGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(749, 315);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 4;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // SyntaxTextBox
            // 
            this.SyntaxTextBox.Location = new System.Drawing.Point(160, 45);
            this.SyntaxTextBox.Name = "SyntaxTextBox";
            this.SyntaxTextBox.Size = new System.Drawing.Size(664, 103);
            this.SyntaxTextBox.TabIndex = 6;
            this.SyntaxTextBox.Text = "";
            // 
            // ToolLabel
            // 
            this.ToolLabel.AutoSize = true;
            this.ToolLabel.Location = new System.Drawing.Point(8, 22);
            this.ToolLabel.Name = "ToolLabel";
            this.ToolLabel.Size = new System.Drawing.Size(55, 20);
            this.ToolLabel.TabIndex = 7;
            this.ToolLabel.Text = "Name:";
            // 
            // SyntaxLabel
            // 
            this.SyntaxLabel.AutoSize = true;
            this.SyntaxLabel.Location = new System.Drawing.Point(156, 22);
            this.SyntaxLabel.Name = "SyntaxLabel";
            this.SyntaxLabel.Size = new System.Drawing.Size(61, 20);
            this.SyntaxLabel.TabIndex = 8;
            this.SyntaxLabel.Text = "Syntax:";
            // 
            // ToolsListBox
            // 
            this.ToolsListBox.FormattingEnabled = true;
            this.ToolsListBox.ItemHeight = 20;
            this.ToolsListBox.Location = new System.Drawing.Point(10, 45);
            this.ToolsListBox.Name = "ToolsListBox";
            this.ToolsListBox.Size = new System.Drawing.Size(144, 264);
            this.ToolsListBox.TabIndex = 9;
            this.ToolsListBox.SelectedIndexChanged += new System.EventHandler(this.ToolsListBox_SelectedIndexChanged);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(12, 318);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(100, 23);
            this.ClientButton.TabIndex = 10;
            this.ClientButton.Text = " Client Folder";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Location = new System.Drawing.Point(118, 319);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(160, 26);
            this.ClientTextBox.TabIndex = 11;
            this.ClientTextBox.Text = "Z:\\XYZ";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(668, 315);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 12;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // MultiHostCheckBox
            // 
            this.MultiHostCheckBox.AutoSize = true;
            this.MultiHostCheckBox.Location = new System.Drawing.Point(545, 320);
            this.MultiHostCheckBox.Name = "MultiHostCheckBox";
            this.MultiHostCheckBox.Size = new System.Drawing.Size(22, 21);
            this.MultiHostCheckBox.TabIndex = 13;
            this.MultiHostCheckBox.UseVisualStyleBackColor = true;
            this.MultiHostCheckBox.CheckedChanged += new System.EventHandler(this.MultiHostCheckBox_CheckedChanged);
            // 
            // HostsButton
            // 
            this.HostsButton.Enabled = false;
            this.HostsButton.Location = new System.Drawing.Point(284, 318);
            this.HostsButton.Name = "HostsButton";
            this.HostsButton.Size = new System.Drawing.Size(75, 23);
            this.HostsButton.TabIndex = 14;
            this.HostsButton.Text = "Hosts File";
            this.HostsButton.UseVisualStyleBackColor = true;
            this.HostsButton.Click += new System.EventHandler(this.HostsButton_Click);
            // 
            // HostsTextBox
            // 
            this.HostsTextBox.Enabled = false;
            this.HostsTextBox.Location = new System.Drawing.Point(365, 319);
            this.HostsTextBox.Name = "HostsTextBox";
            this.HostsTextBox.ReadOnly = true;
            this.HostsTextBox.Size = new System.Drawing.Size(174, 26);
            this.HostsTextBox.TabIndex = 15;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(646, 22);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(140, 20);
            this.OSLabel.TabIndex = 16;
            this.OSLabel.Text = "Operating System:";
            // 
            // OSValueLabel
            // 
            this.OSValueLabel.AutoSize = true;
            this.OSValueLabel.Location = new System.Drawing.Point(754, 22);
            this.OSValueLabel.Name = "OSValueLabel";
            this.OSValueLabel.Size = new System.Drawing.Size(32, 20);
            this.OSValueLabel.TabIndex = 17;
            this.OSValueLabel.Text = "OS";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(157, 151);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(55, 20);
            this.NotesLabel.TabIndex = 18;
            this.NotesLabel.Text = "Notes:";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(160, 174);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(663, 123);
            this.NotesTextBox.TabIndex = 19;
            this.NotesTextBox.Text = "";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(748, 19);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 21;
            this.ConnectButton.Text = "PuTTY";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(6, 22);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(89, 20);
            this.IPLabel.TabIndex = 22;
            this.IPLabel.Text = "Remote IP:";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(74, 19);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(126, 26);
            this.IPTextBox.TabIndex = 23;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(206, 22);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 26;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(396, 22);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 27;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(264, 19);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(126, 26);
            this.UsernameTextBox.TabIndex = 28;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(455, 19);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(126, 26);
            this.PasswordTextBox.TabIndex = 29;
            // 
            // ScpButton
            // 
            this.ScpButton.Location = new System.Drawing.Point(667, 19);
            this.ScpButton.Name = "ScpButton";
            this.ScpButton.Size = new System.Drawing.Size(75, 23);
            this.ScpButton.TabIndex = 30;
            this.ScpButton.Text = "WinSCP";
            this.ScpButton.UseVisualStyleBackColor = true;
            this.ScpButton.Click += new System.EventHandler(this.ScpButton_Click);
            // 
            // ToolGroupBox
            // 
            this.ToolGroupBox.Controls.Add(this.ToolLabel);
            this.ToolGroupBox.Controls.Add(this.SyntaxLabel);
            this.ToolGroupBox.Controls.Add(this.OSLabel);
            this.ToolGroupBox.Controls.Add(this.OSValueLabel);
            this.ToolGroupBox.Controls.Add(this.ToolsListBox);
            this.ToolGroupBox.Controls.Add(this.SyntaxTextBox);
            this.ToolGroupBox.Controls.Add(this.NotesLabel);
            this.ToolGroupBox.Controls.Add(this.NotesTextBox);
            this.ToolGroupBox.Controls.Add(this.ClientButton);
            this.ToolGroupBox.Controls.Add(this.Run);
            this.ToolGroupBox.Controls.Add(this.Export);
            this.ToolGroupBox.Controls.Add(this.MultiHostCheckBox);
            this.ToolGroupBox.Controls.Add(this.HostsTextBox);
            this.ToolGroupBox.Controls.Add(this.ClientTextBox);
            this.ToolGroupBox.Controls.Add(this.HostsButton);
            this.ToolGroupBox.Location = new System.Drawing.Point(9, 36);
            this.ToolGroupBox.Name = "ToolGroupBox";
            this.ToolGroupBox.Size = new System.Drawing.Size(830, 351);
            this.ToolGroupBox.TabIndex = 31;
            this.ToolGroupBox.TabStop = false;
            this.ToolGroupBox.Text = "Tool";
            // 
            // RemoteGroupBox
            // 
            this.RemoteGroupBox.Controls.Add(this.ConnectButton);
            this.RemoteGroupBox.Controls.Add(this.ScpButton);
            this.RemoteGroupBox.Controls.Add(this.PasswordLabel);
            this.RemoteGroupBox.Controls.Add(this.PasswordTextBox);
            this.RemoteGroupBox.Controls.Add(this.IPLabel);
            this.RemoteGroupBox.Controls.Add(this.UsernameTextBox);
            this.RemoteGroupBox.Controls.Add(this.IPTextBox);
            this.RemoteGroupBox.Controls.Add(this.UsernameLabel);
            this.RemoteGroupBox.Location = new System.Drawing.Point(9, 393);
            this.RemoteGroupBox.Name = "RemoteGroupBox";
            this.RemoteGroupBox.Size = new System.Drawing.Size(829, 49);
            this.RemoteGroupBox.TabIndex = 32;
            this.RemoteGroupBox.TabStop = false;
            this.RemoteGroupBox.Text = "Remote Connection";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 33);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.selectFileToolStripMenuItem.Text = "Select XML File...";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // CrowesNest
            // 
            this.ClientSize = new System.Drawing.Size(839, 454);
            this.Controls.Add(this.RemoteGroupBox);
            this.Controls.Add(this.ToolGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CrowesNest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrowesNest";
            this.ToolGroupBox.ResumeLayout(false);
            this.ToolGroupBox.PerformLayout();
            this.RemoteGroupBox.ResumeLayout(false);
            this.RemoteGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.RichTextBox SyntaxTextBox;
        private System.Windows.Forms.Label ToolLabel;
        private System.Windows.Forms.Label SyntaxLabel;
        private System.Windows.Forms.ListBox ToolsListBox;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.CheckBox MultiHostCheckBox;
        private System.Windows.Forms.Button HostsButton;
        private System.Windows.Forms.TextBox HostsTextBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label OSValueLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.RichTextBox NotesTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ScpButton;
        private System.Windows.Forms.GroupBox ToolGroupBox;
        private System.Windows.Forms.GroupBox RemoteGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFileToolStripMenuItem;
    }
}

