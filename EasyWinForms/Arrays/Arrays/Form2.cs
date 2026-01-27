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

    }
}
