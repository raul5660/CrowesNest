using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace CrowesNest
{
    public partial class CrowesNest : Form
    {
        //Deserialize XML configuratio for tools into custom collection of HackTools C:\tools\CrowesNest\cn_config.xml
        public static HackToolCollection tools = HackToolCollection.GetConfiguration();
        private static bool check = false;
        private static string ProgramFilesLocation = (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))) ? "Program Files (x86)" : "Program Files";

        public CrowesNest()
        {
            InitializeComponent();
            //HackToolCollection tools = GetConfiguration();
            //Pupulate combo box with available tools.
            CategoryListBox.DataSource = GetCategories();
            ToolsListBox.DataSource = GetTools((string)CategoryListBox.SelectedItem);
        }

        void Main()
        {
            //Not implemented.
        }
        
        public void ReconfigureTools(string configLocation)
        {
            CrowesNest.tools = HackToolCollection.GetConfiguration(configLocation);
        }

        public List<string> GetTools(string filter)
        {
            //Dynamically update list of tools based on XML configs.
            //List<String> stringList = new List<string>();
            List<string> stringList = new List<string>();
            

            if (filter != "All")
            {
                IEnumerable<HackTool> filteredHackToolList = tools.HackToolList.Where( (tool => tool.Category == filter));
                //stringList = filteredStringList.ToList<string>()

                foreach (HackTool ht in filteredHackToolList)
                {
                    stringList.Add(ht.Name);
                }
            }
            else
            {
                foreach (HackTool ht in tools.HackToolList)
                {
                    stringList.Add(ht.Name);
                }
            }
            
            stringList.Sort();

            return stringList;
        }
        public List<string> GetCategories()
        {
            //Dynamically update list of tools based on XML configs.
            //List<String> stringList = new List<string>();
            List<string> stringList = new List<string>();
            stringList.Add("All");
            foreach (HackTool ht in tools.HackToolList)
            {
                if(ht.Category != String.Empty && !stringList.Contains(ht.Category))
                {
                    stringList.Add(ht.Category);
                }  
            }
            stringList.Sort();
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
                try
                {
                    string[] inputIps = File.ReadAllLines(HostsTextBox.Text);
                    foreach (string ip in inputIps)
                    {
                        tools[(string)ToolsListBox.SelectedItem].Client = ClientTextBox.Text;
                        tools[(string)ToolsListBox.SelectedItem].DeployString = SyntaxTextBox.Text.Replace("x.x.x.x", ip);
                        tools[(string)ToolsListBox.SelectedItem].AutoLog = AutoLoggingcheckBox.Checked;
                        OutputTextBox.AppendText(tools[(string)ToolsListBox.SelectedItem].Deploy(ip, UsernameTextBox.Text, PasswordTextBox.Text));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Cannot deploy tool.");
                }
            }
            else
            {
                tools[(string)ToolsListBox.SelectedItem].Client = ClientTextBox.Text;
                tools[(string)ToolsListBox.SelectedItem].DeployString = SyntaxTextBox.Text;
                tools[(string)ToolsListBox.SelectedItem].AutoLog = AutoLoggingcheckBox.Checked;
                OutputTextBox.AppendText(tools[(string)ToolsListBox.SelectedItem].Deploy(IPTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text));
            }
        }

        private void ToolsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OSValueLabel.Text = tools[(string)ToolsListBox.SelectedItem].OperatingSystem;
            AmmendDirectoryWithClient(ToolsListBox.SelectedItem);
            //Method for dynamically populating Arguments TextBox
            PopulateTextBox();
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolsListBox.DataSource = GetTools((string)CategoryListBox.SelectedItem);
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
            if (MultiHostCheckBox.Checked == true && ScriptCheckBox.Checked == false)
            {
                OutputTextBox.AppendText(tools[(string)ToolsListBox.SelectedItem].ExportMultiCommands(HostsTextBox.Text));

            }
            else if (MultiHostCheckBox.Checked == true && ScriptCheckBox.Checked == true)
            {
                OutputTextBox.AppendText(tools[(string)ToolsListBox.SelectedItem].ExportMultiCommands(HostsTextBox.Text, ScriptTextBox.Text));
            }
            else if (MultiHostCheckBox.Checked == false && ScriptCheckBox.Checked == true)
            {
                OutputTextBox.AppendText(tools[(string)ToolsListBox.SelectedItem].ExportCommands(ScriptTextBox.Text));
            }
            else
            {
                OutputTextBox.AppendText(tools[(string)ToolsListBox.SelectedItem].ExportCommands());
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

        private void ScriptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ScriptCheckBox.Checked == true)
            {
                ScriptButton.Enabled = true;
                ScriptTextBox.Enabled = true;
            }
            else
            {
                ScriptButton.Enabled = false;
                ScriptTextBox.Enabled = false;
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

        private void ScriptButton_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            OpenFileDialog Fld = new OpenFileDialog();

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                ScriptTextBox.Text = Fld.FileName;
            }
        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (IPTextBox.Text != String.Empty && UsernameTextBox.Text != String.Empty && PasswordTextBox.Text != String.Empty)
            {
                try
                {
                    string command = $" -ssh -l {UsernameTextBox.Text} -pw {PasswordTextBox.Text} {IPTextBox.Text}";
                    ProcessStartInfo psInfo = new ProcessStartInfo(@"C:\"+ CrowesNest.ProgramFilesLocation + @"\PuTTY\putty.exe", command);
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
            if (IPTextBox.Text != String.Empty && UsernameTextBox.Text != String.Empty && PasswordTextBox.Text != String.Empty)
            {
                try
                {
                    string command = $" sftp://{UsernameTextBox.Text}:{PasswordTextBox.Text}@{IPTextBox.Text}";
                    ProcessStartInfo psInfo = new ProcessStartInfo(@"C:\" + CrowesNest.ProgramFilesLocation + @"\WinSCP\WinSCP.exe", command);
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
        public void reloadData()
        {
            CategoryListBox.DataSource = GetCategories();
            ToolsListBox.DataSource = GetTools((string)CategoryListBox.SelectedItem);
        }
        private void selectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            OpenFileDialog Fld = new OpenFileDialog();

            if (Fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                ReconfigureTools(Fld.FileName);
                reloadData();
            }
        }

        private void AutoLoggingcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(ClientTextBox.Text) && !check)
            {
                check = true;
                MessageBox.Show(ClientTextBox.Text + " doesn't exist!");
                AutoLoggingcheckBox.CheckState = CheckState.Unchecked;
            }
            check = false;
        }

        private void exportHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Tools\CrowesNest\History\") != true)
            {
                Directory.CreateDirectory(@"C:\Tools\CrowesNest\History\");
            }
            string fileLocation = String.Format(@"C:\Tools\CrowesNest\History\cn_history.txt");
            FileInfo exportFileInfo = new FileInfo(fileLocation);
            using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
            {
                swFile.WriteLine($"CrowesNest History exported on {DateTime.Now}\n\n");
                swFile.WriteLine(OutputTextBox.Text);  
            }
            OutputTextBox.AppendText($"Exported History to C:\\Tools\\CrowesNest\\History\\cn_history.txt\nTime: {DateTime.Now}\n\n");
        }

        private void addToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTool Window = new AddTool();
            Window.Show();
        }
        
    }
}
