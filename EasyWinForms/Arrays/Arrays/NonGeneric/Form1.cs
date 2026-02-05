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

        private void button2_Click(object sender, EventArgs e)
        {
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie" };
            string[] nameList2 = { "Alex", "Sophie", "Abigail", "Frannie", "Marika" };
            //---------------------------------
            int i;
            string item;
            this.listBox1.Items.Clear();
            //---------------------------------
            for (i = 0; i < nameList.Length; i++)
            {
                item = nameList[i];
                this.listBox1.Items.Add(item);
            }
            //---------------------------------
            for (i = 0; i < nameList2.Length; i++)
            {
                nameList2[i] = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth" };
            //---------------------------------------
            foreach (string item in nameList)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            //---------------------------------------
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth", "Cindy", "Heather", "Mitch" };
            this.listBox1.Items.AddRange(nameList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //---------------------------------------
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth", "Cindy", "Heather", "Bilbo" };
            Int32[] nameList2 = { 1, 12, 32, 98, 56, 77, 803, 4 };
            //------------ASC sort items-------------
            Array.Sort(nameList);
            this.listBox1.Items.AddRange(nameList);
            //---------------------------------------
            //------------ASC sort items-------------
            Array.Sort(nameList2);
            //---------------------------------------
            foreach (Int32 item in nameList2)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            //---------------------------------------
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth", "Cindy", "Heather", "Gretchen" };
            Int32[] nameList2 = { 1, 12, 32, 98, 56, 77, 803, 4 };
            //------------DESC sort items-------------
            Array.Sort(nameList);
            Array.Reverse(nameList);
            this.listBox1.Items.AddRange(nameList);
            //return;
            //---------------------------------------
            Array.Sort(nameList2);
            Array.Reverse(nameList2);
            foreach (Int32 item in nameList2)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------
            Int32[] nameList2 = { 1, 12, 32, 98, 56, 77, 803, 4 };
            MessageBox.Show("The minimum number is: " + nameList2.Min().ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------
            Int32[] nameList2 = { 1, 12, 32, 98, 56, 77, 803, 4 };
            MessageBox.Show("The maximum number is: " + nameList2.Max().ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth"};
            string[] target_array = new string[5];
            nameList.CopyTo(target_array, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth" };
            Array.Resize(ref nameList, 10);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth" };
            Array.Clear(nameList, 0, nameList.Length);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] nameList = { "Alex", "Sophie", "Abigail", "Frannie", "Beth" };
            //this.Text = Array.IndexOf(nameList, this.search_txtbox.Text).ToString();
            Int32 r;
            r = Array.IndexOf(nameList, this.search_txtbox.Text);
            if (r > -1)
            {
                System.Windows.Forms.MessageBox.Show("Found: Index is: " + r.ToString());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not Found: Index is: " + r.ToString());
            }
        }
    }
}
