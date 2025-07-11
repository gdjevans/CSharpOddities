using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.searchID_txtbox.Text == "")
            {
                MessageBox.Show("ID is empty");
                return;
            }
            // --------------------------------
            string fn;
            fn = "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\phoneBook\\PhoneBook\\bin\\textfiles\\";
            string p;
            string r;
            // -------------------- First Name --------
            p = fn + this.searchID_txtbox.Text + "_fn.txt";
            if (System.IO.File.Exists(p))
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.FN_txtbox.Text = r;
            }
            // -------------------- Last Name --------
            p = fn + this.searchID_txtbox.Text + "_ln.txt";
            if (System.IO.File.Exists(p))
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.LN_txtbox.Text = r;
            }
            // -------------------- Telephone --------
            p = fn + this.searchID_txtbox.Text + "_tel.txt";
            if (System.IO.File.Exists(p))
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Tel_txtbox.Text = r;
            }
            // -------------------- Cell Mobile Number --------
            p = fn + this.searchID_txtbox.Text + "_mob.txt";
            if (System.IO.File.Exists(p))
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.cell_txtbox.Text = r;
            }
            // -------------------- Email --------
            p = fn + this.searchID_txtbox.Text + "_email.txt";
            if (System.IO.File.Exists(p))
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_txtbox.Text = r;
            }
            // -------------------- Address --------
            p = fn + this.searchID_txtbox.Text + "_add.txt";
            if (System.IO.File.Exists(p))
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Address_txtbox.Text = r;
            }
            // -------------------- Comment --------
            p = fn + this.searchID_txtbox.Text + "_comment.txt";
            if (System.IO.File.Exists(p))
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.Comment_txtbox.Text = r;
            }
            // ---------------------------------------------------
            this.ID_txtbox.Text = this.searchID_txtbox.Text;
        }
    }
}
