using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace CrowesNest
{
    public partial class CrowesNest : Form
    {
        //Deserialize XML configuratio for tools into custom collection of HackTools C:\tools\CrowesNest\cn_config.xml
        HackToolCollection tools = HackToolCollection.GetConfiguration();

        public CrowesNest()
        {
            InitializeComponent();
            //HackToolCollection tools = GetConfiguration();
            //Pupulate combo box with available tools.
            ToolsListBox.DataSource = GetTools();
        }

        void Main()
        {
            //Not implemented
        }
        
        public string[] GetTools()
        {
            //Dynamically update list of tools based on XML configs.
            //List<String> stringList = new List<string>();
            string[] stringList = new string[tools.HackToolList.Count];
            int count = 0;
            foreach(HackTool ht in tools.HackToolList)
            {
                stringList[count] = ht.Name;
                count++;
            }
            Array.Sort(stringList);
            return stringList;
        }

        //Method for dynamically populating Arguments TextBox
        public void PopulateTextBox()
        {
            SyntaxTextBox.Text = tools[(string)ToolsListBox.SelectedItem].Location + " " + tools[(string)ToolsListBox.SelectedItem].Arguments;
            NotesTextBox.Text = tools[(string)ToolsListBox.SelectedItem].Notes;
        }

        public void AmmendDirectoryWithClient(object selectedTool)
        {
            tools[(string)selectedTool].Arguments = tools[(string)selectedTool].Arguments.Replace(tools[(string)selectedTool].Client, ClientTextBox.Text);

            if (tools[(string)selectedTool].Arguments.Contains("\\\\"))
            {
                tools[(string)selectedTool].Arguments = tools[(string)selectedTool].Arguments.Replace("\\\\", "\\");
            }
            tools[(string)selectedTool].Client = ClientTextBox.Text;
        }
 
        //Update any user input into Argument textbox into Argument property of selected tool.
        private void Run_Click(object sender, EventArgs e)
        {
            if (MultiHostCheckBox.Checked == true)
            {
                MessageBox.Show("Please export and use script for executing tool while \"Hosts File\" is selected.");
            }
            else
            {
                tools[(string)ToolsListBox.SelectedItem].DeployString = SyntaxTextBox.Text;
                tools[(string)ToolsListBox.SelectedItem].Deploy(IPTextBox.Text, UsernameTextBox.Text,PasswordTextBox.Text);
            }   
        }

        private void ToolsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OSValueLabel.Text = tools[(string)ToolsListBox.SelectedItem].OperatingSystem;
            AmmendDirectoryWithClient(ToolsListBox.SelectedItem);
            //Method for dynamically populating Arguments TextBox
            PopulateTextBox();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog Fld = new FolderBrowserDialog();
            
            // Show the "Make new folder" button
            Fld.ShowNewFolderButton = true;

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                ClientTextBox.Text = Fld.SelectedPath;
            }
        }
        //Exports syntax to script.
        private void Export_Click(object sender, EventArgs e)
        {
            tools[(string)ToolsListBox.SelectedItem].DeployString = SyntaxTextBox.Text;
            if (MultiHostCheckBox.Checked == true)
            {
                tools[(string)ToolsListBox.SelectedItem].ExportMultiCommands(HostsTextBox.Text);
            }
            else
            {
                tools[(string)ToolsListBox.SelectedItem].ExportCommands();
            }
           
        }

        private void MultiHostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiHostCheckBox.Checked == true)
            {
                HostsButton.Enabled = true;
                HostsTextBox.Enabled = true;
            }
            else
            {
                HostsButton.Enabled = false;
                HostsTextBox.Enabled = false;
            }
        }

        private void HostsButton_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            OpenFileDialog Fld = new OpenFileDialog();

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                HostsTextBox.Text = Fld.FileName;
            }
        }

        private void SaveNotesButton_Click(object sender, EventArgs e)
        {
            tools[(string)ToolsListBox.SelectedItem].Notes = NotesTextBox.Text;
            tools[(string)ToolsListBox.SelectedItem].SaveNotes();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (IPTextBox.Text != "" && UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo(@"C:\Program Files (x86)\PuTTY\putty.exe", " -ssh -l " + UsernameTextBox.Text + " -pw " + PasswordTextBox.Text + " " + IPTextBox.Text);
                    psInfo.UseShellExecute = false;

                    using (Process exeProcess = Process.Start(psInfo)) { }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Cannot deploy tool.");
                }

            }
            else
            {
                MessageBox.Show("Please provide connection information!");
            }
           
        }

        private void ScpButton_Click(object sender, EventArgs e)
        {
            if (IPTextBox.Text != "" && UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo(@"C:\Program Files (x86)\WinSCP\WinSCP.exe", " sftp://" + UsernameTextBox.Text + ":" + PasswordTextBox.Text + "@" + IPTextBox.Text);
                    psInfo.UseShellExecute = false;

                    using (Process exeProcess = Process.Start(psInfo)) { }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Cannot deploy tool.");
                }

            }
            else
            {
                MessageBox.Show("Please provide connection information!");
            }
        }
    }
}
