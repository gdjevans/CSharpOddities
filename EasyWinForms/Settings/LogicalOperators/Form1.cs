using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogicalOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 age;
            Int32.TryParse(textBox2.Text, out age);

            if ((this.textBox1.Text =="Bob") && (age>20) && (age<50))
            {
                MessageBox.Show("You win life!");
            }
            else
            {
                MessageBox.Show("You loser!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "Bobby") || (this.textBox1.Text == "Bob"))
            {
                MessageBox.Show("You win life!");
            }
            else
            {
                MessageBox.Show("You loser!");
            }
        }
    }
}
