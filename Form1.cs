using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp4ClipCutter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void chooseFile_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Dialog opened");
            //add an option to change the default path of fileDialog
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Debug.WriteLine(fileDialog.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fileDialog already initialized in Form1.Designer.cs
            fileDialog.Filter = "mp4 files|*.mp4";
            Debug.WriteLine("Program launched");
        }

        private void resolutionChange_CheckedChanged(object sender, EventArgs e)
        {
            if (resolutionChange.Checked == true)
            {
                resDropDown.Visible = true;

            }
        }
    }
    public partial class Config
    {

    }
}
