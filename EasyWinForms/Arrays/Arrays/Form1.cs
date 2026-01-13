using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void manual_btn_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add("Sata");
            this.listBox1.Items.Add("Alex");
            this.listBox1.Items.Add("Murry");
            this.listBox1.Items.Add("MJ");
        }

        private void infinite_array_btn_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            //----------------Simple Infinite Array-------------------------
            string[] nameList = {"Alex", "Sara", "Tim", "Frannie", "Sophie"};
            //---------------Advanced Infinite Array------------------------
            string[] nameList2;
            nameList2 = new string[] {"Alex", "Sara", "Tim", "Frannie", "Sophie"};
            //-------------------------Int Array----------------------------
            Int32[] userCode = { 23, 4010, 89, 6003, 6609 };
            //--------------------------------------------------------------
            this.listBox1.Items.AddRange(nameList2);
        }

        private void limited_array_btn_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            //----------------Simple Limited Array-------------------------
            string[] nameList = new string[3]{ "Not Selected", "Male", "Female" };
            //---------------Advanced Limited Array------------------------
            string[] nameList2;
            nameList2 = new string[3] { "Not Selected", "Male", "Female" };
            //--------------------------------------------------------------
            this.listBox1.Items.AddRange(nameList2);
        }

        private void indexRead_btn_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            //----------------Simple Infinite Array-------------------------
            string[] nameList = { "Alex", "Sara", "Tim", "Frannie", "Sophie" };
            Int32 r;
            Int32.TryParse(this.index_txtbox.Text, out r);
            this.Text = nameList[r];
            this.listBox1.Items.AddRange(nameList);
        }

        private void indexWrite_btn_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            //----------------Simple Infinite Array-------------------------
            string[] nameList = { "Alex", "Sara", "Tim", "Frannie", "Sophie" };
            Int32 r;
            Int32.TryParse(this.index_txtbox.Text, out r);
            nameList[r] = "Abigail";
            this.listBox1.Items.AddRange(nameList);
        }

        private void Size_btn_Click(object sender, EventArgs e)
        {
            string[] nameList = { "Alex", "Sara", "Tim", "Frannie", "Sophie" };
            this.Text = nameList.Length.ToString();
        }
    }
}
