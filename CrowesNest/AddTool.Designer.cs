namespace CrowesNest
{
    partial class AddTool
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.ArgumentsLabel = new System.Windows.Forms.Label();
            this.OperatingSystemLabel = new System.Windows.Forms.Label();
            this.Noteslabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.ArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OperatingSystemComboBox = new System.Windows.Forms.ComboBox();
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(67, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(54, 43);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location";
            // 
            // ArgumentsLabel
            // 
            this.ArgumentsLabel.AutoSize = true;
            this.ArgumentsLabel.Location = new System.Drawing.Point(45, 70);
            this.ArgumentsLabel.Name = "ArgumentsLabel";
            this.ArgumentsLabel.Size = new System.Drawing.Size(57, 13);
            this.ArgumentsLabel.TabIndex = 2;
            this.ArgumentsLabel.Text = "Arguments";
            // 
            // OperatingSystemLabel
            // 
            this.OperatingSystemLabel.AutoSize = true;
            this.OperatingSystemLabel.Location = new System.Drawing.Point(12, 97);
            this.OperatingSystemLabel.Name = "OperatingSystemLabel";
            this.OperatingSystemLabel.Size = new System.Drawing.Size(90, 13);
            this.OperatingSystemLabel.TabIndex = 3;
            this.OperatingSystemLabel.Text = "Operating System";
            // 
            // Noteslabel
            // 
            this.Noteslabel.AutoSize = true;
            this.Noteslabel.Location = new System.Drawing.Point(64, 124);
            this.Noteslabel.Name = "Noteslabel";
            this.Noteslabel.Size = new System.Drawing.Size(35, 13);
            this.Noteslabel.TabIndex = 4;
            this.Noteslabel.Text = "Notes";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(50, 365);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(49, 13);
            this.Categorylabel.TabIndex = 5;
            this.Categorylabel.Text = "Category";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(426, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(105, 40);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(426, 20);
            this.LocationTextBox.TabIndex = 7;
            // 
            // ArgumentsTextBox
            // 
            this.ArgumentsTextBox.Location = new System.Drawing.Point(105, 67);
            this.ArgumentsTextBox.Name = "ArgumentsTextBox";
            this.ArgumentsTextBox.Size = new System.Drawing.Size(426, 20);
            this.ArgumentsTextBox.TabIndex = 8;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(105, 121);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(426, 234);
            this.NotesTextBox.TabIndex = 10;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(105, 362);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(426, 20);
            this.CategoryTextBox.TabIndex = 11;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(456, 388);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(375, 388);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OperatingSystemComboBox
            // 
            this.OperatingSystemComboBox.FormattingEnabled = true;
            this.OperatingSystemComboBox.Items.AddRange(new object[] {
            "Windows",
            "Linux"});
            this.OperatingSystemComboBox.Location = new System.Drawing.Point(105, 93);
            this.OperatingSystemComboBox.Name = "OperatingSystemComboBox";
            this.OperatingSystemComboBox.Size = new System.Drawing.Size(426, 21);
            this.OperatingSystemComboBox.TabIndex = 14;
            // 
            // AddTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 423);
            this.Controls.Add(this.OperatingSystemComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.ArgumentsTextBox);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.Noteslabel);
            this.Controls.Add(this.OperatingSystemLabel);
            this.Controls.Add(this.ArgumentsLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddTool";
            this.Text = "AddTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTool_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label ArgumentsLabel;
        private System.Windows.Forms.Label OperatingSystemLabel;
        private System.Windows.Forms.Label Noteslabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox ArgumentsTextBox;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox OperatingSystemComboBox;
    }
}