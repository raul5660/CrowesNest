using System;
using System.Collections.Generic;
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

        public string Client { get; set; }
        public string DeployString { get; set; }
        
        

        public HackTool()
        {
            this.Client = @"Z:\XYZ";
        }


        //Created needed syntax then deploys the tool.
        public void Deploy(string ip, string username, string password)
        {
            if (this.OperatingSystem.ToLower() == "windows")
            {
                try
                {   // wrap binaries in cmd.exe /K to keep cmd.exe open after completion of process.
                    string deployCommand = String.Format($"/K \"{this.DeployString}\"");
                    ProcessStartInfo psInfo = new ProcessStartInfo("cmd.exe", deployCommand);
                    psInfo.UseShellExecute = true;

                    using(Process exeProcess = Process.Start(psInfo)) { }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Cannot deploy tool.");
                }
            }
            
            else
            {   
                if (ip != "" && username != "" && password != "")
                {
                    try
                    {
                        string deployCommand = String.Format($"/K \"\"C:\\Program Files (x86)\\PuTTY\\plink.exe\" -pw {password} {username}@{ip} {this.DeployString}\"");
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
                MessageBox.Show("Error:\nProblem exporting to C:\\Tools\\CrowesNest\\Bash or C:\\Tools\\CrowesNest\\Batch \nMake sure directories exist and Hosts file is selected.");
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
                MessageBox.Show("Error:\nProblem exporting to C:\\Tools\\CrowesNest\\Bash or C:\\Tools\\CrowesNest\\Batch \nMake sure directories exist and Hosts file is selected.");
            }
        }
    }

    //Custom collection for Deserialization. Open to ideas on more elegent solutions. Just learning use of XML
    [XmlRoot("HackToolCollection")]
    public class HackToolCollection
    {
        [XmlArray("HackToolList")]
        [XmlArrayItem("HackTool", typeof(HackTool))]
        public List<HackTool> HackToolList { get; set; } //The collection of tools
        

        //Custom indexer so I can choose tools base don their name. I would use dict if i knew how to use XML deserialization with it. Will refactor in future.
        public HackTool this[string index]
        {
            get
            {
                int indexNumber = 0;
                foreach (HackTool tool in HackToolList)
                {
                    if (index == tool.Name)
                    {
                        return HackToolList[indexNumber];
                    }
                    indexNumber++;
                }
                return HackToolList[0];
            }
        }
        //ordinal index through collection
        public HackTool this[int index]
        {
            get
            {  
                return HackToolList[index];
            }
        }
       
        //Deserialize XML configuratio for tools into custom collection of HackTools C:\tools\CrowesNest\cn_config.xml
        static public HackToolCollection GetConfiguration()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(HackToolCollection));
            try
            {
                if (Directory.Exists(@"C:\tools\CrowesNest\") != true)
                {
                    Directory.CreateDirectory(@"C:\tools\CrowesNest\");
                }
                
                using (FileStream fileStream = new FileStream(@"C:\tools\CrowesNest\cn_config.xml", FileMode.OpenOrCreate))
                {
                    HackToolCollection tools = (HackToolCollection)serializer.Deserialize(fileStream);
                    return tools;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem in C:\\tools\\CrowesNest\\cn_config.xml\n1. If directory or file did not exist, we created it for you.\n2. Confirm file contains proper XML configuration.\n3. Restart application.");
                System.Environment.Exit(1);
            }
            //XmlSerializer serializer = new XmlSerializer(typeof(HackToolCollection));
            using (FileStream fileStream = new FileStream(@"C:\tools\CrowesNest\cn_config.xml", FileMode.Open))
            {
                HackToolCollection tools = (HackToolCollection)serializer.Deserialize(fileStream);
                return tools;
            }
        }
    }
   
}
