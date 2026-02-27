using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UsingDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("temp");
            DirectoryInfo dr = new DirectoryInfo("temp2");
            dr.Create();
            MessageBox.Show("Folder was created");

            DirectoryInfo drr = new DirectoryInfo("folder2");
            string accessTime = drr.LastAccessTime.ToString();
            MessageBox.Show(accessTime);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", "new");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp");
            MessageBox.Show("Folder deleted");
        }
    }
}
