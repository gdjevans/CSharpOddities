using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.txt_fileName.Text = this.openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.txt_fileName.Text) == true)
            {
                this.textBox2.Text = System.IO.File.GetCreationTime(this.txt_fileName.Text).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.txt_fileName.Text) == true)
            {
                this.textBox2.Text = System.IO.File.GetLastWriteTime(this.txt_fileName.Text).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.txt_fileName.Text) == true)
            {
                this.textBox2.Text = System.IO.File.GetLastAccessTime(this.txt_fileName.Text).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.txt_fileName.Text) == true)
            {
                this.txt_fileName.Text = System.IO.Path.GetFileNameWithoutExtension(this.txt_fileName.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(this.txt_fileName.Text) == true)
            {
                this.txt_getExtension.Text = System.IO.Path.GetExtension(this.txt_fileName.Text);
            }
        }
    }
}
