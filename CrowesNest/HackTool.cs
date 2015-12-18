﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    ProcessStartInfo psInfo = new ProcessStartInfo("cmd.exe", "/K \" " + this.DeployString + "\"");
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
                        ProcessStartInfo psInfo = new ProcessStartInfo("cmd.exe", "/K \"\"C:\\Program Files (x86)\\PuTTY\\plink.exe\" -pw " + password + " " + username +"@"+ ip + " " + this.DeployString + "\"");
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
                    FileInfo exportFileInfo = new FileInfo(@"C:\Tools\CrowesNest\Batch" + "\\" + this.Name + ".bat");
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        swFile.WriteLine(this.DeployString);
                        swFile.WriteLine("pause");
                        swFile.Close();
                    }  
                }
                else
                {
                    FileInfo exportFileInfo = new FileInfo(@"C:\Tools\CrowesNest\Bash" + "\\" + this.Name + ".sh");
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        swFile.WriteLine("#! /bin/bash");
                        swFile.WriteLine(this.DeployString);
                        swFile.Close();
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

                //string[] inputIps = File.ReadAllLines(hostFile);
                if (this.OperatingSystem.ToLower() == "windows")
                {

                    FileInfo exportFileInfo = new FileInfo(@"C:\Tools\CrowesNest\Batch" + "\\" + this.Name + ".bat");
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        foreach (string ip in inputIps)
                        {
                            swFile.WriteLine(this.DeployString.Replace("x.x.x.x", ip));
                        }
                        swFile.WriteLine("pause");
                        swFile.Close();
                    }       
                }
                else
                {
                    FileInfo exportFileInfo = new FileInfo(@"C:\Tools\CrowesNest\Bash" + "\\" + this.Name + ".sh");
                    using (StreamWriter swFile = new StreamWriter(exportFileInfo.FullName))
                    {
                        swFile.WriteLine("#! /bin/bash");
                        foreach (string ip in inputIps)
                        {
                            swFile.WriteLine(this.DeployString.Replace("x.x.x.x", ip));
                        }
                        swFile.Close();
                    }
                }
                        
            }
            catch (Exception)
            {
                MessageBox.Show("Error:\nProblem exporting to C:\\Tools\\CrowesNest\\Bash or C:\\Tools\\CrowesNest\\Batch \nMake sure directories exist and Hosts file is selected.");
            }
        }
        public void SaveNotes()
        {
            //Serialize Notes property only....
            //XmlSerializer serializer = new XmlSerializer(typeof(HackToolCollection));
            //using (FileStream fileStream = new FileStream(@"C:\tools\CrowesNest\cn_configwrite.xml", FileMode.Open))
            //{
            //    serializer.Serialize(fileStream, this);
            //}
            MessageBox.Show(@"Saving notes not supported yet, please save them manually to C:\tools\CrowesNest\cn_config.xml");
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
                
                using (FileStream fileStream = new FileStream(@"C:\tools\CrowesNest\cn_config.xml", FileMode.Open))
                {
                    HackToolCollection tools = (HackToolCollection)serializer.Deserialize(fileStream);
                    return tools;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error:\nProblem in C:\\tools\\CrowesNest\\cn_config.xml\nConfirm file exists and contains proper XML");
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