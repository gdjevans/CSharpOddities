using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays.Generic
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>() { "Sassy", "Penelope" };
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            li.AddRange(new string[] { "Item1", "Item2" });
            //-----------------------------------
            System.Collections.Generic.List<Int32> li2 = new System.Collections.Generic.List<Int32>() { 68, 22395};
            System.Collections.Generic.List<Button> li_button = new System.Collections.Generic.List<Button>() { this.button1 };
            li_button.Add(this.button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            Int32 index;
            Int32.TryParse(this.textBox1.Text, out index);
            this.Text = li[index];
            //-----------------------------------
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            Int32 index;
            Int32.TryParse(this.textBox1.Text, out index);
            li[index] = "Test";
            //-----------------------------------
            li.Insert(2, "New Name");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            Int32 index;
            Int32.TryParse(this.textBox1.Text, out index);
            li.RemoveAt(index);
            //-----------------------------------
            Boolean r;
            r = li.Remove("Sophie");
            //-----------------------------------
            if(r == true)
            {
                MessageBox.Show("Removed!");
            }
            else
            {
                MessageBox.Show("Not Found!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            this.Text = li.Count.ToString();
            li.Remove("Soda");
            this.Text = li.Count.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            foreach (string item in li)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            foreach (string item in li)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            li.Sort();
            foreach (string item in li)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            li.Sort();
            li.Reverse();
            foreach (string item in li)
            {
                this.listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            string[] target_array = new string[li.Count()];
            li.CopyTo(target_array);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            li.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<string> li = new System.Collections.Generic.List<string>();
            li.Add("Abigail");
            li.Add("Frannie");
            li.Add("Sophie");
            li.Add("Faye");
            li.Add("Soda");
            //-----------------------------------
            Boolean r;
            r = li.Contains(this.textBox2.Text);
            if (r)
            {
                MessageBox.Show("Found " + this.textBox2.Text);
            }
            else 
            {
                MessageBox.Show("NOT Found " + this.textBox2.Text);
            }
            //-----------------------------------
            Int32 i;
            i = li.IndexOf(this.textBox2.Text);
            if (i >=0)
            {
                MessageBox.Show("Found index " + i);
            }
            else
            {
                MessageBox.Show("NOT Found " + this.textBox2.Text);
            }
        }
    }
}
