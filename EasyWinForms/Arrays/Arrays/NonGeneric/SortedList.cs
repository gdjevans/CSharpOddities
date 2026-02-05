using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arrays
{
    public partial class SortedList : Form
    {
        public SortedList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList(); 
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out r);
            //-------------------------------
            //this.Text = sl[r].ToString();
            //--------------get items by index-----------------
            object key;
            key = sl.GetByIndex(r);
            this.Text = key.ToString();
            //-------------------------------------------------
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
           
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out r);
            //-------------------------------
            sl[55] = "Test";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out r);
            //-------------------------------
            //sl.Remove(r); // delete by key
            //-------------------------------
            sl.RemoveAt(r); // delete by index

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            this.Text = sl.Count.ToString();
            //-------------------------------
            sl.Add(63, "Mytea");
            this.Text = sl.Count.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            for (int i = 0; i < sl.Count; i++)
            {
                this.listBox2.Items.Add(sl.GetByIndex(i).ToString());
                this.listBox1.Items.Add(sl.GetKey(i).ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            foreach (object item in sl)
            {
                System.Collections.DictionaryEntry de;
                de = (System.Collections.DictionaryEntry)item;
                this.listBox2.Items.Add(de.Value.ToString());
                this.listBox1.Items.Add(de.Key.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            object[] target_array = new object[sl.Count]; 
            sl.CopyTo(target_array, 0);
            //--------------copy keys-------------------
            sl.Keys.CopyTo(target_array, 0);
            //-----------------copy values---------------------
            sl.Values.CopyTo(target_array, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            sl.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            Boolean r;
            Int32 key;
            Int32.TryParse(this.textBox2.Text, out key);
            r = sl.ContainsKey(key);
            if (r == true)
            {
                System.Windows.Forms.MessageBox.Show("Found " + this.textBox2.Text);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not Found " + this.textBox2.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add(16, "Abigail");
            sl.Add(93, "Frannie");
            sl.Add(22, "Sophie");
            sl.Add(55, "Soda");
            sl.Add(63, "Teva");
            //-------------------------------
            Boolean r;

            r = sl.ContainsValue(this.textBox3.Text);
            if (r == true)
            {
                System.Windows.Forms.MessageBox.Show("Found " + this.textBox3.Text);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not Found " + this.textBox3.Text);
            }
        }
    }
}
