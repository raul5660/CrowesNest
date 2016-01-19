using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace CrowesNest
{
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
        static public HackToolCollection GetConfiguration(string location = @"C:\tools\CrowesNest\cn_config.xml")
        {
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
            catch (Exception)
            {
                MessageBox.Show("Problem in C:\\tools\\CrowesNest\\cn_config.xml\n1. If directory or file did not exist, we created it for you.\n2. Confirm file contains proper XML configuration.\n3. Restart application.");
                System.Environment.Exit(1);
            }

            return tools = null;
        }
    }
}
