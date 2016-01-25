using System;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

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

        public string Client { get; set; } = @"Z:\XYZ";
        public string DeployString { get; set; }
        public bool AutoLog { get; set; }

        public HackTool()
        {
            //this.Client = @"Z:\XYZ";
        }

        private string RunCommand(string command)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", command);
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            string results = process.StandardOutput.ReadToEnd();
            if (results == "")
            {
                results = process.StandardError.ReadToEnd();
            }
            return results;
        }
        //Created needed syntax then deploys the tool.
        public string Deploy(string ip, string username, string password)
        {
            Regex rgx = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            string TemporaryFileName = "";
            string Output = "";
            if (this.OperatingSystem.ToLower() == "windows")
            {
                try
                {
                    string deployCommand = "";
                    if (ip != String.Empty && username == String.Empty && password == String.Empty)
                    {
                        StringBuilder tmp = new StringBuilder();
                        tmp.Append("/c");
                        tmp.Append(" \"");
                        TemporaryFileName = rgx.Replace(this.DeployString, ip);
                        tmp.Append(TemporaryFileName);
                        tmp.Append("\"");
                        deployCommand = tmp.ToString();
                    }
                    else
                    {
                        TemporaryFileName = this.DeployString;
                        deployCommand = $"/c \"{this.DeployString}\"";
                    }
                    if (deployCommand != "")
                    {
                        if (this.AutoLog)
                        {
                            TemporaryFileName = TemporaryFileName.Replace("/c", "").Replace(" ", "_").Replace(" \"", "").Replace("\"", "");
                            TemporaryFileName += ".txt";
                            Output = RunCommand(deployCommand);
                            if (!File.Exists(this.Client + @"\" + TemporaryFileName))
                            {
                                using (StreamWriter OutputFile = new StreamWriter(this.Client + @"\" + TemporaryFileName, true))
                                {
                                    OutputFile.Write(Output);
                                }
                            }
                        }
                        else
                        {
                            Output = RunCommand(deployCommand);
                        }
                        return Output;
                    }
                    else
                    {
                        MessageBox.Show("Error: Cannot deploy tool.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Cannot deploy tool.");
                }
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
            return "";
        }

        private void ExeProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        //export syntax to .bat or .sh for appropriate platform.
        public void ExportCommands()
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
                    
                }
            }
            
            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and/or Script File is selected.");
            }

        }
        public void ExportCommands(string scriptOuputFile)
        {
            try
            {
                FileInfo exportFileInfo = new FileInfo(scriptOuputFile);
                using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName, true))
                {
                    swFile.WriteLine(this.DeployString);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and / or Script File is selected.");
            }

        }
        //Support for export functionnality to scale with many hosts.
        public void ExportMultiCommands(string hostFile)
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
                }       
            }
            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and/or Script File is selected.");
            }
        }
        public void ExportMultiCommands(string hostFile, string scriptOuputFile)
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
                
            }
            catch (Exception)
            {
                MessageBox.Show("Problem exporting. Make sure Hosts file and/or Script File is selected.");
            }
        }

    }
}
