using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte[] Array = new byte[5];
            rnd.NextBytes(Array);
            label1.Text = Array[0].ToString();
            label2.Text = Array[1].ToString();
            label3.Text = Array[2].ToString();
            label4.Text = Array[3].ToString();
            label5.Text = Array[4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string allValid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!£$@?><%^&*()";
            string result = "";
            Random rnd2 = new Random();
            for (int i = 0; i < 6; i++)
            {
                result += allValid[rnd2.Next(0, Convert.ToInt32(allValid.Length))];
            }
            label1.Text = result;
        }
    }
}
