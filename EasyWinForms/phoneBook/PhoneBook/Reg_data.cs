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
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            this.New_btn.Enabled = false;
            this.Save_btn.Enabled = true;
            this.Info_group.Enabled = true;
            // --------- Clear textboxes ---------
            this.ID_txtbox.ResetText();
            this.FN_txtbox.ResetText();
            this.LN_txtbox.ResetText();
            this.Tel_txtbox.ResetText();
            this.cell_txtbox.ResetText();
            this.email_txtbox.ResetText();
            this.Address_txtbox.ResetText();
            this.Comment_txtbox.ResetText();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (this.ID_txtbox.Text == "")
            {
                MessageBox.Show("You must enter an ID");
                return;
            }
            this.Save_btn.Enabled = false;
            this.New_btn.Enabled = true;
            this.Info_group.Enabled = false;
            // --------------------------------
            string fn;
            fn = "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\phoneBook\\PhoneBook\\bin\\textfiles\\";
            string p;
            // -------------------- First Name --------
            p = fn + this.ID_txtbox.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.FN_txtbox.Text, Encoding.UTF8);
            // -------------------- Last Name --------
            p = fn + this.ID_txtbox.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.LN_txtbox.Text, Encoding.UTF8);
            // -------------------- Telephone --------
            p = fn + this.ID_txtbox.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.Tel_txtbox.Text, Encoding.UTF8);
            // -------------------- Mob. no. --------
            p = fn + this.ID_txtbox.Text + "_mob.txt";
            System.IO.File.WriteAllText(p, this.cell_txtbox.Text, Encoding.UTF8);
            // -------------------- Email --------
            p = fn + this.ID_txtbox.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.email_txtbox.Text, Encoding.UTF8);
            // -------------------- Address --------
            p = fn + this.ID_txtbox.Text + "_add.txt";
            System.IO.File.WriteAllText(p, this.Address_txtbox.Text, Encoding.UTF8);
            // -------------------- Comment --------
            p = fn + this.ID_txtbox.Text + "_comment.txt";
            System.IO.File.WriteAllText(p, this.Comment_txtbox.Text, Encoding.UTF8);
            //---------------------------------------
            MessageBox.Show("Saved..!");
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.Info_group.Enabled = false;
        }
    }
}
