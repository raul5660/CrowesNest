using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Text;

namespace CrowesNest
{
    //Custom collection for Deserialization. Open to ideas on more elegent solutions. Just learning use of XML
    [XmlRoot("HackToolCollection")]
    public class HackToolCollection
    {
        [XmlArray("HackToolList")]
        [XmlArrayItem("HackTool", typeof(HackTool))]
        public List<HackTool> HackToolList { get; set; } //The collection of tools
        private static string ProgramFilesLocation = (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))) ? "Program Files (x86)" : "Program Files";

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
        static public HackToolCollection GetConfiguration(string location = @"C:\tools\CrowesNest\cn_config.xml")
        {
            if (!HackTool.AreDependenciesMet())
            {
                HackTool.Dependencies Check = HackTool.GetDependenciesMet();
                StringBuilder output = new StringBuilder();
                output.Append("Not all dependencies are met, so please check to make sure you have the following: ");
                if ((HackTool.Dependencies.plink & Check) != HackTool.Dependencies.plink)
                {
                    output.Append("\nC:\\" + ProgramFilesLocation + "\\PuTTY\\plink.exe");
                }
                if ((HackTool.Dependencies.putty & Check) != HackTool.Dependencies.putty)
                {
                    output.Append("\nC:\\" + ProgramFilesLocation + "\\PuTTY\\putty.exe");
                }
                if ((HackTool.Dependencies.winscp & Check) != HackTool.Dependencies.winscp)
                {
                    output.Append("\nC:\\" + ProgramFilesLocation + "\\WinSCP\\WinSCP.exe");
                }
                if ((HackTool.Dependencies.powershell & Check) != HackTool.Dependencies.powershell)
                { 
                output.Append("\nPowershell Version 5: https://www.microsoft.com/en-us/download/details.aspx?id=48729");
                }
                MessageBox.Show(output.ToString());
                System.Environment.Exit(1);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(HackToolCollection));
            HackToolCollection tools;
            try
            {
                if (Directory.Exists(@"C:\tools\CrowesNest\") != true)
                {
                    Directory.CreateDirectory(@"C:\tools\CrowesNest\");
                }

                using (FileStream fileStream = new FileStream(location, FileMode.OpenOrCreate))
                {
                    tools = (HackToolCollection)serializer.Deserialize(fileStream);
                    return tools;
                }
            }
            catch (Exception e)
            {
                if (e.InnerException.Message == "Root element is missing.")
                {
                    using (StreamWriter outputFile = new StreamWriter(location))
                    {
                        outputFile.Write("<HackToolCollection><HackToolList><HackTool><Name></Name><Location></Location><Arguments></Arguments><OperatingSystem></OperatingSystem><Notes></Notes><Category></Category></HackTool></HackToolList></HackToolCollection>");
                    }
                }
                MessageBox.Show("Problem in C:\\tools\\CrowesNest\\cn_config.xml\n1. If directory or file did not exist, we created it for you.\n2. Confirm file contains proper XML configuration.\n3. Restart application.");
                System.Environment.Exit(1);
            }

            return tools = null;
        }
    }
}
