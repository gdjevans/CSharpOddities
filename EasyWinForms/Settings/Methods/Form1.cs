using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = sum_calc().ToString();
        }

        public Int32 sum_calc()
        {
            Int32 fn;
            Int32 sn;
            Int32 rn;
            // ----------------
            Int32.TryParse(textBox1.Text, out fn);
            Int32.TryParse(textBox2.Text, out sn);
            // ----------------
            rn = fn + sn;
            return rn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sum_calc2();
        }
        public void sum_calc2()
        {
            Int32 fn;
            Int32 sn;
            Int32 rn;
            // ----------------
            Int32.TryParse(textBox1.Text, out fn);
            Int32.TryParse(textBox2.Text, out sn);
            // ----------------
            rn = fn + sn;
            this.textBox3.Text = rn.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myClass.myMsg();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
