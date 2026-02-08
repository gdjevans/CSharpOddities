using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text, TextDataFormat.UnicodeText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean b = Clipboard.ContainsText();
            if (b)
            {
                this.textBox2.Text = Clipboard.GetText();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(this.pictureBox1.Image);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Boolean b = Clipboard.ContainsImage();
            if (b)
            {
                this.pictureBox1.Image = Clipboard.GetImage();
                this.BackgroundImage = this.pictureBox1.Image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
