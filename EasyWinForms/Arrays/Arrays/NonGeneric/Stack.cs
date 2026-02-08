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
    public partial class Stack : Form
    {
        public Stack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
            object r;
            r = st.Peek();
            this.Text = r.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
            object r;
            r = st.Pop();
            this.Text = r.ToString();
            //------------------------------------------
            r = st.Pop();
            //------------------------------------------
            r = st.Pop();
            //------------------------------------------
            r = st.Pop();
            //------------------------------------------
            r = st.Pop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
            this.Text = st.Count.ToString();
            //------------------------------------------------------
            object r;
            r = st.Pop();
            //------------------------------------------------------
            this.Text = st.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
            foreach (object item in st)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
            string[] target_list = new string[st.Count];
            st.CopyTo(target_list, 0);
            //------------------------------------------------------
            object[] target_list2 = new object[st.Count];
            target_list2 = st.ToArray();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
            st.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Abigail");
            st.Push("Frannie");
            st.Push("Sophie");
            st.Push("Soda");
            st.Push("Teva");
            //------------------------------------------------------
            Boolean r;
            r = st.Contains(this.textBox2.Text);
            if (r)
            {
                System.Windows.Forms.MessageBox.Show("Found " + this.textBox2.Text);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not Found " + this.textBox2.Text);
            }

        }
    }
}
