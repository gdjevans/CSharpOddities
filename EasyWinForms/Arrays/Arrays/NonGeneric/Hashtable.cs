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
    public partial class Hashtable : Form
    {
        public Hashtable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            //---------------------------------------
            //this.Text = ht[93].ToString();
            Int32 key;
            Int32.TryParse(this.textBox1.Text, out key);    
            this.Text = ht[key].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            //---------------------------------------
            //ht[55] = "Test";
            Int32 key;
            Int32.TryParse(this.textBox1.Text, out key);
            ht[key] = "Test";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            //---------------------------------------
            Int32 key;
            Int32.TryParse(this.textBox1.Text, out key);
            ht.Remove(key);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            //---------------------------------------
            this.Text = ht.Count.ToString();
            ht.Add(49, "Abigail");
            this.Text = ht.Count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            ht.Add(49, "Abigail");
            //---------------------------------------
            foreach (object item in ht)
            {
                System.Collections.DictionaryEntry de;
                de = (System.Collections.DictionaryEntry)item;
                //-----------------------------------------
                this.listBox1.Items.Add(de.Key.ToString());
                this.listBox2.Items.Add(de.Value.ToString());
            }
            //---------------------------------------
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();    
            //---------------------------------------
            foreach (System.Collections.DictionaryEntry item in ht)
            {
                //-----------------------------------------
                this.listBox1.Items.Add(item.Key.ToString());
                this.listBox2.Items.Add(item.Value.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            ht.Add(49, "Abigail");
            //---------------------------------------
            ht.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            ht.Add(49, "Abigail");
            //---------------------------------------
            object[] target_array = new object[ht.Count];
            ht.CopyTo(target_array, 0);
            //-----------------copy keys----------------------
            object[] target_keys_array = new object[ht.Keys.Count];
            ht.Keys.CopyTo(target_keys_array, 0);
            //-----------------copy values--------------------
            object[] target_values_array = new object[ht.Values.Count];
            ht.Values.CopyTo(target_values_array, 0);
            //---------------------------------------
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            ht.Add(49, "Abigail");
            //---------------------------------------
            Int32 key;
            Int32.TryParse(this.textBox2.Text, out key);
            Boolean r;
            r = ht.ContainsKey(key);
            if (r==true)
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
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add(25, "Tania");
            ht.Add(93, "Frannie");
            ht.Add(22, "Sophie");
            ht.Add(55, "Trent");
            ht.Add(371, "Boris");
            ht.Add(49, "Abigail");
            //---------------------------------------
            Boolean r;
            r = ht.ContainsKey(this.textBox3.Text);
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
