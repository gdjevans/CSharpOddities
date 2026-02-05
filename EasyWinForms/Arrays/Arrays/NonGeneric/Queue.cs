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
    public partial class Queue : Form
    {
        public Queue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
            object r;
            r = q.Peek();
            this.Text = r.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
            object r;
            r = q.Dequeue();
            //--------------------------
            this.listBox1.Items.Add(r.ToString());
            //--------------------------
            r = q.Dequeue();
            this.listBox1.Items.Add(r.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
            this.Text = q.Count.ToString();
            //------------------------------------------------------
            q.Dequeue();
            //------------------------------------------------------
            this.Text = q.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
            foreach (object item in q)
            {
                this.listBox1.Items.Add(item.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
            q.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
            string[] target_array = new string[q.Count];
            q.CopyTo(target_array, 0);
            //------------------------------------------------------
            object[] target_array_2 = new object[q.Count];
            target_array_2 = q.ToArray();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Abigail");
            q.Enqueue("Frannie");
            q.Enqueue("Sophie");
            q.Enqueue("Soda");
            q.Enqueue("Teva");
            //------------------------------------------------------
            Boolean r;
            r = q.Contains(this.textBox2.Text);
            if (r == true) 
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
