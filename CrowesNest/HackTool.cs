using System;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace CrowesNest
{
    //Class represents the Hacking Tool used on the job,
    [Serializable()]
    public class HackTool
    {
        //Associating hacktool properties with correlationg XML elements for deserialization.
        [XmlElement("Name")]
        public string Name { get; set; } //Used for comboBox selection

        [XmlElement("Location")]
        public string Location { get; set; } //The binaries actual location on the disk

        [XmlElement("Arguments")]
        public string Arguments { get; set; } //Syntax of the selected tool

        [XmlElement("OperatingSystem")]
        public string OperatingSystem { get; set; }

        [XmlElement("Notes")]
        public string Notes { get; set; }

        [XmlElement("Category")]
        public string Category { get; set; }

        //public string Client { get; set; } = @"Z:\XYZ";
        public string Client { get; set; } = @"C:\Users\Raul Martinez\Desktop\test output";
        public string DeployString { get; set; }
        public bool AutoLog { get; set; }

        public HackTool()
        {
            //this.Client = @"Z:\XYZ";
        }
       
        //Created needed syntax then deploys the tool.
        public string Deploy(string ip, string username, string password)
        {
            if (this.OperatingSystem.ToLower() == "windows")
            {
                try
                {
                    if (!this.AutoLog)
                    {
                        string deployCommand = String.Format("-NoExit -command &{{{0}}}", this.DeployString);
                        ProcessStartInfo psInfo = new ProcessStartInfo("powershell.exe", deployCommand);
                        psInfo.UseShellExecute = true;

                        using (Process exeProcess = Process.Start(psInfo)) { }
                    }
                    else
                    {
                        string tmpfilename = this.DeployString.Replace(" ", "_");
                        string deployCommand = $"-NoExit -Command &{{Start-Transcript -Path '{this.Client}\\{tmpfilename}.txt'; {this.DeployString}; Stop-Transcript}}";
                        ProcessStartInfo psInfo = new ProcessStartInfo("powershell.exe", deployCommand);
                        psInfo.UseShellExecute = true;

                        using (Process exeProcess = Process.Start(psInfo)) { }
                        return $"Running Windows Command: {this.DeployString}\nTime: {DateTime.Now.ToString()}\nTranscript logged to: {this.Client}\\{tmpfilename}.txt\n\n";
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Cannot deploy tool.");
                }
                return $"Running Windows Command: {this.DeployString}\nTime: {DateTime.Now.ToString()}\n\n";
            }

            else
            {   
                if (ip != String.Empty && username != String.Empty && password != String.Empty)
                {
                    try
                    {
                        string deployCommand = $"/K \"\"C:\\Program Files (x86)\\PuTTY\\plink.exe\" -pw {password} {username}@{ip} {this.DeployString}\"";
                        ProcessStartInfo psInfo = new ProcessStartInfo("cmd.exe", deployCommand);
                        psInfo.UseShellExecute = false;

                        using ( Process exeProcess = Process.Start(psInfo)) { }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error: Cannot deploy tool.");
                    }
                    return $"Running Linux Command: {this.DeployString}\nTime: {DateTime.Now.ToString()}\n\n";
                }
                else
                {
                    MessageBox.Show("Please provide connection information!");
                }
                return "";
            }
        }

        //export syntax to .bat or .sh for appropriate platform.
        public string ExportCommands()
        {
            try
            {
                if (this.OperatingSystem.ToLower() == "windows")
                {
                    if(Directory.Exists(@"C:\Tools\CrowesNest\Batch\") != true)
                    {
                        Directory.CreateDirectory(@"C:\Tools\CrowesNest\Batch\");
                    }

                    string fileLocation = String.Format($@"C:\Tools\CrowesNest\Batch\{this.Name}.bat");
                    FileInfo exportFileInfo = new FileInfo(fileLocation);
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        swFile.WriteLine(this.DeployString);
                        swFile.WriteLine("pause");
                    }
                    return $"Exporting Windows Script: C:\\Tools\\CrowesNest\\Batch\\{this.Name}.bat\nTime: {DateTime.Now.ToString()}\n\n";
                }
                else
                {
                    if (Directory.Exists(@"C:\Tools\CrowesNest\Bash\") != true)
                    {
                        Directory.CreateDirectory(@"C:\Tools\CrowesNest\Bash\");
                    }
                    string fileLocation = String.Format($@"C:\Tools\CrowesNest\Bash\{this.Name}.sh");
                    FileInfo exportFileInfo = new FileInfo(fileLocation);
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        swFile.WriteLine("#! /bin/bash");
                        swFile.WriteLine(this.DeployString);
                    }
                    return $"Exporting Linux Script: C:\\Tools\\CrowesNest\\Bash\\{this.Name}.sh\nTime: {DateTime.Now.ToString()}\n\n";
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and/or Script File is selected.");
                return $"Error exporting \"C:\\Tools\\CrowesNest\\Bash\\{this.Name}.sh\"\nTime: {DateTime.Now.ToString()}\n\n";
            }

        }
        public string ExportCommands(string scriptOuputFile)
        {
            try
            {
                FileInfo exportFileInfo = new FileInfo(scriptOuputFile);
                using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName, true))
                {
                    swFile.WriteLine(this.DeployString);
                }
                return $"Exporting {this.DeployString} to {scriptOuputFile}\nTime: {DateTime.Now.ToString()}\n\n";
            }

            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and / or Script File is selected.");
                return $"Error exporting {this.DeployString} to {scriptOuputFile}\nTime: {DateTime.Now.ToString()}\n\n";
            }

        }
        //Support for export functionnality to scale with many hosts.
        public string ExportMultiCommands(string hostFile)
        {
            try
            {
                string[] inputIps = File.ReadAllLines(hostFile);


                if (this.OperatingSystem.ToLower() == "windows")
                {
                    if (Directory.Exists(@"C:\Tools\CrowesNest\Batch\") != true)
                    {
                        Directory.CreateDirectory(@"C:\Tools\CrowesNest\Batch\");
                    }

                    string fileLocation = String.Format($@"C:\Tools\CrowesNest\Batch\{this.Name}.bat");
                    FileInfo exportFileInfo = new FileInfo(fileLocation);
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        foreach (string ip in inputIps)
                        {
                            swFile.WriteLine(this.DeployString.Replace("x.x.x.x", ip));
                        }
                        swFile.WriteLine("pause");
                    }
                    return $"Exporting Multi-Hosts Windows Script: C:\\Tools\\CrowesNest\\Batch\\{this.Name}.bat\nTime: {DateTime.Now.ToString()}\n\n";
                }
                else
                {
                    if (Directory.Exists(@"C:\Tools\CrowesNest\Bash\") != true)
                    {
                        Directory.CreateDirectory(@"C:\Tools\CrowesNest\Bash\");
                    }
                    string fileLocation = String.Format($@"C:\Tools\CrowesNest\Bash\{this.Name}.sh");
                    FileInfo exportFileInfo = new FileInfo(fileLocation);
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        swFile.WriteLine("#! /bin/bash");
                        foreach (string ip in inputIps)
                        {
                            swFile.WriteLine(this.DeployString.Replace("x.x.x.x", ip));
                        }
                    }
                    return $"Exporting Multi-Hosts Linux Script: C:\\Tools\\CrowesNest\\Bash\\{this.Name}.sh\nTime: {DateTime.Now.ToString()}\n\n";
                }       
            }
            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and/or Script File is selected.");
                return $"Error exporting Multi-Hosts Linux \"C:\\Tools\\CrowesNest\\Bash\\{this.Name}.sh\"\nTime: {DateTime.Now.ToString()}\n\n";
            }
        }
        public string ExportMultiCommands(string hostFile, string scriptOuputFile)
        {
            try
            {
                string[] inputIps = File.ReadAllLines(hostFile);
                FileInfo exportFileInfo = new FileInfo(scriptOuputFile);
                using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName,true))
                {
                    foreach (string ip in inputIps)
                    {
                        swFile.WriteLine(this.DeployString.Replace("x.x.x.x", ip));
                    }
                }
                return $"Exporting Multi-Host Cross Tool scripting {this.DeployString} to {scriptOuputFile}\nTime: {DateTime.Now.ToString()}\n\n";
            }
            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and/or Script File is selected.");
                return $"Error exporting {this.DeployString} to {scriptOuputFile}\nTime: {DateTime.Now.ToString()}\n\n";
            }
        }
    }
}
