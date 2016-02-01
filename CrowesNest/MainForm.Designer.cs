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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DeploymentGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoLoggingcheckBox = new System.Windows.Forms.CheckBox();
            this.ScriptLabel = new System.Windows.Forms.Label();
            this.ScriptCheckBox = new System.Windows.Forms.CheckBox();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.ScriptButton = new System.Windows.Forms.Button();
            this.HostsLabel = new System.Windows.Forms.Label();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.addToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolGroupBox.SuspendLayout();
            this.RemoteGroupBox.SuspendLayout();
            this.DeploymentGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.OutputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(488, 34);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 4;
            this.Run.Text = "&Run Tool";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // SyntaxTextBox
            // 
            this.SyntaxTextBox.Location = new System.Drawing.Point(312, 45);
            this.SyntaxTextBox.Name = "SyntaxTextBox";
            this.SyntaxTextBox.Size = new System.Drawing.Size(612, 115);
            this.SyntaxTextBox.TabIndex = 6;
            this.SyntaxTextBox.Text = "";
            // 
            // ToolLabel
            // 
            this.ToolLabel.AutoSize = true;
            this.ToolLabel.Location = new System.Drawing.Point(162, 22);
            this.ToolLabel.Name = "ToolLabel";
            this.ToolLabel.Size = new System.Drawing.Size(38, 13);
            this.ToolLabel.TabIndex = 7;
            this.ToolLabel.Text = "Name:";
            // 
            // SyntaxLabel
            // 
            this.SyntaxLabel.AutoSize = true;
            this.SyntaxLabel.Location = new System.Drawing.Point(312, 22);
            this.SyntaxLabel.Name = "SyntaxLabel";
            this.SyntaxLabel.Size = new System.Drawing.Size(42, 13);
            this.SyntaxLabel.TabIndex = 8;
            this.SyntaxLabel.Text = "Syntax:";
            // 
            // ToolsListBox
            // 
            this.ToolsListBox.FormattingEnabled = true;
            this.ToolsListBox.Location = new System.Drawing.Point(162, 45);
            this.ToolsListBox.Name = "ToolsListBox";
            this.ToolsListBox.Size = new System.Drawing.Size(144, 264);
            this.ToolsListBox.TabIndex = 9;
            this.ToolsListBox.SelectedIndexChanged += new System.EventHandler(this.ToolsListBox_SelectedIndexChanged);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(5, 21);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(100, 23);
            this.ClientButton.TabIndex = 10;
            this.ClientButton.Text = " Client Folder";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Location = new System.Drawing.Point(111, 22);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(188, 20);
            this.ClientTextBox.TabIndex = 11;
            this.ClientTextBox.Text = "Z:\\XYZ";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(488, 59);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 12;
            this.Export.Text = "&Export Tool";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // MultiHostCheckBox
            // 
            this.MultiHostCheckBox.AutoSize = true;
            this.MultiHostCheckBox.Location = new System.Drawing.Point(304, 52);
            this.MultiHostCheckBox.Name = "MultiHostCheckBox";
            this.MultiHostCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MultiHostCheckBox.TabIndex = 13;
            this.MultiHostCheckBox.UseVisualStyleBackColor = true;
            this.MultiHostCheckBox.CheckedChanged += new System.EventHandler(this.MultiHostCheckBox_CheckedChanged);
            // 
            // HostsButton
            // 
            this.HostsButton.Enabled = false;
            this.HostsButton.Location = new System.Drawing.Point(5, 50);
            this.HostsButton.Name = "HostsButton";
            this.HostsButton.Size = new System.Drawing.Size(100, 23);
            this.HostsButton.TabIndex = 14;
            this.HostsButton.Text = "Hosts File";
            this.HostsButton.UseVisualStyleBackColor = true;
            this.HostsButton.Click += new System.EventHandler(this.HostsButton_Click);
            // 
            // HostsTextBox
            // 
            this.HostsTextBox.Enabled = false;
            this.HostsTextBox.Location = new System.Drawing.Point(111, 50);
            this.HostsTextBox.Name = "HostsTextBox";
            this.HostsTextBox.ReadOnly = true;
            this.HostsTextBox.Size = new System.Drawing.Size(187, 20);
            this.HostsTextBox.TabIndex = 15;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(743, 22);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(93, 13);
            this.OSLabel.TabIndex = 16;
            this.OSLabel.Text = "Operating System:";
            // 
            // OSValueLabel
            // 
            this.OSValueLabel.AutoSize = true;
            this.OSValueLabel.Location = new System.Drawing.Point(880, 22);
            this.OSValueLabel.Name = "OSValueLabel";
            this.OSValueLabel.Size = new System.Drawing.Size(22, 13);
            this.OSValueLabel.TabIndex = 17;
            this.OSValueLabel.Text = "OS";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Location = new System.Drawing.Point(312, 163);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(38, 13);
            this.NotesLabel.TabIndex = 18;
            this.NotesLabel.Text = "Notes:";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(312, 186);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(612, 123);
            this.NotesTextBox.TabIndex = 19;
            this.NotesTextBox.Text = "";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(229, 34);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 21;
            this.ConnectButton.Text = "&PuTTY";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(11, 26);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(60, 13);
            this.IPLabel.TabIndex = 22;
            this.IPLabel.Text = "Remote IP:";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(79, 22);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(126, 20);
            this.IPTextBox.TabIndex = 23;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(11, 53);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 26;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(11, 82);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 27;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(79, 50);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(126, 20);
            this.UsernameTextBox.TabIndex = 28;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(79, 79);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(126, 20);
            this.PasswordTextBox.TabIndex = 29;
            // 
            // ScpButton
            // 
            this.ScpButton.Location = new System.Drawing.Point(229, 59);
            this.ScpButton.Name = "ScpButton";
            this.ScpButton.Size = new System.Drawing.Size(75, 23);
            this.ScpButton.TabIndex = 30;
            this.ScpButton.Text = "&WinSCP";
            this.ScpButton.UseVisualStyleBackColor = true;
            this.ScpButton.Click += new System.EventHandler(this.ScpButton_Click);
            // 
            // ToolGroupBox
            // 
            this.ToolGroupBox.Controls.Add(this.RemoteGroupBox);
            this.ToolGroupBox.Controls.Add(this.CategoryLabel);
            this.ToolGroupBox.Controls.Add(this.DeploymentGroupBox);
            this.ToolGroupBox.Controls.Add(this.CategoryListBox);
            this.ToolGroupBox.Controls.Add(this.ToolLabel);
            this.ToolGroupBox.Controls.Add(this.SyntaxLabel);
            this.ToolGroupBox.Controls.Add(this.OSLabel);
            this.ToolGroupBox.Controls.Add(this.OSValueLabel);
            this.ToolGroupBox.Controls.Add(this.ToolsListBox);
            this.ToolGroupBox.Controls.Add(this.SyntaxTextBox);
            this.ToolGroupBox.Controls.Add(this.NotesLabel);
            this.ToolGroupBox.Controls.Add(this.NotesTextBox);
            this.ToolGroupBox.Location = new System.Drawing.Point(9, 25);
            this.ToolGroupBox.Name = "ToolGroupBox";
            this.ToolGroupBox.Size = new System.Drawing.Size(937, 444);
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
            this.RemoteGroupBox.Location = new System.Drawing.Point(12, 321);
            this.RemoteGroupBox.Name = "RemoteGroupBox";
            this.RemoteGroupBox.Size = new System.Drawing.Size(321, 112);
            this.RemoteGroupBox.TabIndex = 32;
            this.RemoteGroupBox.TabStop = false;
            this.RemoteGroupBox.Text = "Remote Connection";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(8, 22);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 21;
            this.CategoryLabel.Text = "Category:";
            // 
            // DeploymentGroupBox
            // 
            this.DeploymentGroupBox.Controls.Add(this.AutoLoggingcheckBox);
            this.DeploymentGroupBox.Controls.Add(this.ScriptLabel);
            this.DeploymentGroupBox.Controls.Add(this.ClientTextBox);
            this.DeploymentGroupBox.Controls.Add(this.ScriptCheckBox);
            this.DeploymentGroupBox.Controls.Add(this.HostsButton);
            this.DeploymentGroupBox.Controls.Add(this.ScriptTextBox);
            this.DeploymentGroupBox.Controls.Add(this.HostsTextBox);
            this.DeploymentGroupBox.Controls.Add(this.ScriptButton);
            this.DeploymentGroupBox.Controls.Add(this.MultiHostCheckBox);
            this.DeploymentGroupBox.Controls.Add(this.Export);
            this.DeploymentGroupBox.Controls.Add(this.HostsLabel);
            this.DeploymentGroupBox.Controls.Add(this.Run);
            this.DeploymentGroupBox.Controls.Add(this.ClientButton);
            this.DeploymentGroupBox.Location = new System.Drawing.Point(339, 321);
            this.DeploymentGroupBox.Name = "DeploymentGroupBox";
            this.DeploymentGroupBox.Size = new System.Drawing.Size(585, 112);
            this.DeploymentGroupBox.TabIndex = 34;
            this.DeploymentGroupBox.TabStop = false;
            this.DeploymentGroupBox.Text = "Deployment";
            // 
            // AutoLoggingcheckBox
            // 
            this.AutoLoggingcheckBox.AutoSize = true;
            this.AutoLoggingcheckBox.Location = new System.Drawing.Point(304, 24);
            this.AutoLoggingcheckBox.Name = "AutoLoggingcheckBox";
            this.AutoLoggingcheckBox.Size = new System.Drawing.Size(69, 17);
            this.AutoLoggingcheckBox.TabIndex = 37;
            this.AutoLoggingcheckBox.Text = "Auto Log";
            this.AutoLoggingcheckBox.UseVisualStyleBackColor = true;
            this.AutoLoggingcheckBox.CheckedChanged += new System.EventHandler(this.AutoLoggingcheckBox_CheckedChanged);
            // 
            // ScriptLabel
            // 
            this.ScriptLabel.AutoSize = true;
            this.ScriptLabel.Location = new System.Drawing.Point(320, 82);
            this.ScriptLabel.Name = "ScriptLabel";
            this.ScriptLabel.Size = new System.Drawing.Size(123, 13);
            this.ScriptLabel.TabIndex = 36;
            this.ScriptLabel.Text = "Use Cross Tool Scripting";
            // 
            // ScriptCheckBox
            // 
            this.ScriptCheckBox.AutoSize = true;
            this.ScriptCheckBox.Location = new System.Drawing.Point(304, 81);
            this.ScriptCheckBox.Name = "ScriptCheckBox";
            this.ScriptCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ScriptCheckBox.TabIndex = 35;
            this.ScriptCheckBox.UseVisualStyleBackColor = true;
            this.ScriptCheckBox.CheckedChanged += new System.EventHandler(this.ScriptCheckBox_CheckedChanged);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Enabled = false;
            this.ScriptTextBox.Location = new System.Drawing.Point(111, 79);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.ReadOnly = true;
            this.ScriptTextBox.Size = new System.Drawing.Size(187, 20);
            this.ScriptTextBox.TabIndex = 34;
            // 
            // ScriptButton
            // 
            this.ScriptButton.Enabled = false;
            this.ScriptButton.Location = new System.Drawing.Point(5, 79);
            this.ScriptButton.Name = "ScriptButton";
            this.ScriptButton.Size = new System.Drawing.Size(100, 23);
            this.ScriptButton.TabIndex = 33;
            this.ScriptButton.Text = "Script File";
            this.ScriptButton.UseVisualStyleBackColor = true;
            this.ScriptButton.Click += new System.EventHandler(this.ScriptButton_Click);
            // 
            // HostsLabel
            // 
            this.HostsLabel.AutoSize = true;
            this.HostsLabel.Location = new System.Drawing.Point(320, 53);
            this.HostsLabel.Name = "HostsLabel";
            this.HostsLabel.Size = new System.Drawing.Size(75, 13);
            this.HostsLabel.TabIndex = 22;
            this.HostsLabel.Text = "Use Hosts File";
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(12, 45);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(144, 264);
            this.CategoryListBox.TabIndex = 20;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem,
            this.addToolToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "&Configure";
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectFileToolStripMenuItem.Text = "Select XML File...";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportHistoryToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.exportToolStripMenuItem.Text = "History";
            // 
            // exportHistoryToolStripMenuItem
            // 
            this.exportHistoryToolStripMenuItem.Name = "exportHistoryToolStripMenuItem";
            this.exportHistoryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportHistoryToolStripMenuItem.Text = "Export History...";
            this.exportHistoryToolStripMenuItem.Click += new System.EventHandler(this.exportHistoryToolStripMenuItem_Click);
            // 
            // OutputGroup
            // 
            this.OutputGroup.Controls.Add(this.OutputTextBox);
            this.OutputGroup.Location = new System.Drawing.Point(9, 476);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Size = new System.Drawing.Size(937, 141);
            this.OutputGroup.TabIndex = 34;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "History";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 19);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(912, 110);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.Text = "";
            // 
            // addToolToolStripMenuItem
            // 
            this.addToolToolStripMenuItem.Name = "addToolToolStripMenuItem";
            this.addToolToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addToolToolStripMenuItem.Text = "Add Tool";
            this.addToolToolStripMenuItem.Click += new System.EventHandler(this.addToolToolStripMenuItem_Click);
            // 
            // CrowesNest
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(961, 622);
            this.Controls.Add(this.OutputGroup);
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
            this.DeploymentGroupBox.ResumeLayout(false);
            this.DeploymentGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.OutputGroup.ResumeLayout(false);
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
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Label HostsLabel;
        private System.Windows.Forms.Label ScriptLabel;
        private System.Windows.Forms.CheckBox ScriptCheckBox;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.Button ScriptButton;
        private System.Windows.Forms.GroupBox DeploymentGroupBox;
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.CheckBox AutoLoggingcheckBox;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolToolStripMenuItem;
    }
}

