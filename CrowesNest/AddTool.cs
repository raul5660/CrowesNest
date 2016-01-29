using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CrowesNest
{
    public partial class AddTool : Form
    {
        public AddTool()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String Name = this.NameTextBox.Text;
            String Location = this.LocationTextBox.Text;
            String Arguments = this.ArgumentsTextBox.Text;
            String OperatingSystem = this.OperatingSystemTextBox.Text;
            String Notes = this.NotesTextBox.Text;
            String Category = this.CategoryTextBox.Text;
            XmlSerializer serializer = new XmlSerializer(typeof(HackToolCollection));
            using (FileStream fileStream = new FileStream("C:\\tools\\CrowesNest\\cn_config.xml", FileMode.Create))
            {
                CrowesNest.tools.HackToolList.Add(new HackTool(Name, Location, Arguments, OperatingSystem, Notes, Category));
                serializer.Serialize(fileStream, CrowesNest.tools);
            }
            this.Close();
        }
    }
}
