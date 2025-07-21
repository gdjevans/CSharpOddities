using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatString
{
    public partial class Form1 : Form
    {
        string startTime;
        
        public Form1()
        {
            InitializeComponent();
            startTime = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dateDiff = Int32.Parse(this.time_lbl.Text.Replace(":", "")) - Int32.Parse(startTime.ToString().Replace(":", ""));

            this.textBox2.Text = "You have taken" + dateDiff.ToString() + " seconds";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.time_lbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = startTime;
            label1.Visible = true;
            time_lbl.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Int64 i;
            Int64.TryParse(this.textBox3.Text, out i);

            this.textBox4.Text = i.ToString("#,#");
        }
    }
}
