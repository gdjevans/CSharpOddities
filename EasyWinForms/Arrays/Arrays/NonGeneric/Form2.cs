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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList nameList = new System.Collections.ArrayList() { 122, 25.14, true, "Blueberry", this.button1};
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda" };
            nameList.Add(nn);
            //------------------------------
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(nameList.ToArray());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList() { 122, 25.14, true, "Blueberry", this.button1 };
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda" };
            nameList.Add(nn);
            //------------------------------
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(nameList.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda" };
            nameList.Add(nn);
            //------------------------------
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out r);
            this.Text = nameList[r].ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda" };
            nameList.Add(nn);
            //------------------------------
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out r);
            this.Text = nameList[r].ToString();
            nameList[r] = "Unitarian";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda" };
            nameList.Add(nn);
            //------------------------------
            Int32 r;
            Int32.TryParse(this.textBox1.Text, out r);
            //------------------------------
            //nameList.RemoveAt(r);
            object o;
            o = nameList[r];
            nameList.Remove(o);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda", "Calli" };
            nameList.Add(nn);
            //------------------------------
            this.Text = nameList.Count.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda", "Calli" };
            nameList.Add(nn);
            //------------------------------
            Int32 c;
            c = nameList.Count;
            this.Text = c.ToString();
            //------------------------------
            for (int i = 0; i < c; i++)
            {
                //-------------read item---------------------
                this.listBox1.Items.Add(nameList[i].ToString());
                //----------edit item----------------
               // nameList[i] = "Item " + i.ToString();
                //--------------------------
            }
            //------------------------------
            this.listBox1.Items.Add("----------------------------");
            //------------------------------
            for (int i = 0; i < c; i++)
            {
                //--------------------------
                string dt;
                dt = nameList[i].GetType().ToString();
                this.listBox1.Items.Add(dt);
                //--------------------------
                if (nameList[i].GetType() == typeof(Arrays.Form2))
                {
                    this.listBox1.Items.Add("-----Form found------");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add(85.639);
            nameList.Add(11429);
            nameList.Add(this);
            //------------------------------
            string[] nn = { "Ali", "Jess", "Sophie", "Soda", "Calli" };
            nameList.Add(nn);
            //------------------------------
            this.listBox1.Items.Clear();
            //-------------Get the arraylist item-----------------
            foreach (Object item in nameList)
            {
                this.listBox1.Items.Add(item.ToString());
                //---------------------------------------
            }
            //------------------------------------------------------
            this.listBox1.Items.Add("----------------------------");
            //----------Get the array list type---------------------
            foreach (Object item in nameList)
            {
                //------------------------------------
                string dt;
                dt = item.GetType().ToString();
                this.listBox1.Items.Add(dt);
                //------------------------------------
                if (item.GetType() == typeof(Arrays.Form2))
                {
                    this.listBox1.Items.Add("--------Found item---------");
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add("Abi");
            nameList.Add("Jess");
            nameList.Add("Sophie");
            nameList.Add("Soda");
            nameList.Add("Calli");
            //------------------------------
            //------------------------------
            nameList.Sort();
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(nameList.ToArray());
            //-----------------------------------------
            var nameList2 = new System.Collections.ArrayList();
            nameList2.Add(85.6);
            nameList2.Add(2);
            nameList2.Add(99.66);
            nameList2.Add(88.37);
            nameList2.Add(10.40);
            nameList2.Add(82.31);
            nameList2.Add(93.63);
            //------------------------------
            //------------------------------
            nameList2.Sort();
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(nameList2.ToArray());

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add("Abi");
            nameList.Add("Jess");
            nameList.Add("Sophie");
            nameList.Add("Soda");
            nameList.Add("Calli");
            //------------------------------
            //------------------------------
            nameList.Sort();
            nameList.Reverse();
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(nameList.ToArray());
            //-----------------------------------------
            var nameList2 = new System.Collections.ArrayList();
            nameList2.Add(85.6);
            nameList2.Add(2);
            nameList2.Add(99.66);
            nameList2.Add(88.37);
            nameList2.Add(10.40);
            nameList2.Add(82.31);
            nameList2.Add(93.63);
            //------------------------------
            //------------------------------
            nameList2.Sort();
            nameList2.Reverse();
            this.listBox1.Items.Clear();
            this.listBox1.Items.AddRange(nameList2.ToArray());
            //--------------------------------

        }

        private void button13_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add("Abi");
            nameList.Add("Jess");
            nameList.Add("Sophie");
            nameList.Add("Soda");
            nameList.Add("Calli");
            //------------------------------
            string[] target_nameList = new string[nameList.Count];
            nameList.CopyTo(target_nameList);
            //------------------------------
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add("Abi");
            nameList.Add("Jess");
            nameList.Add("Sophie");
            nameList.Add("Soda");
            nameList.Add("Calli");
            //------------------------------
            nameList.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add("Abi");
            nameList.Add("Jess");
            nameList.Add("Sophie");
            nameList.Add("Soda");
            nameList.Add("Calli");
            //------------------------------
            nameList.Insert(3, "Test");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var nameList = new System.Collections.ArrayList();
            nameList.Add("Frannie");
            nameList.Add("Soda");
            nameList.Add("Abi");
            nameList.Add("Jess");
            nameList.Add("Sophie");
            nameList.Add("Soda");
            nameList.Add("Calli");
            //------------------------------
            Boolean r;
            r = nameList.Contains(this.textBox2.Text);
            //----------get index-----------
            Int32 index;
            index = nameList.IndexOf(this.textBox2.Text);
            //--------------------------
            if (r == true)
            {
                
                System.Windows.Forms.MessageBox.Show("Found! Index: " + index.ToString());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not Found");
            }
        }
    }
}
