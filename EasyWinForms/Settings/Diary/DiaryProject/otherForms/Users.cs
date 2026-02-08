using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryProject.otherForms
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == " " || this.txtUserName.TextLength == 0)
            {
                MessageBox.Show("User name is empty, who are you?");
                return;
            }
            if (this.txtPassword.Text != this.txtPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match, twit!");
                return;
            }
            DiaryProject.Properties.Settings.Default.userName = this.txtUserName.Text;
            DiaryProject.Properties.Settings.Default.userPass = this.txtPassword.Text;    
            DiaryProject.Properties.Settings.Default.Save();
            // ----------------Save user pic ----------------
            if (this.openFileDialog1.FileName != "openFileDialog1")
            {
                string fn;
                fn = this.openFileDialog1.FileName;
                string df;
                df = Application.StartupPath + "\\data\\userPics\\1.jpg";
                System.IO.File.Copy(fn, df, true);
            }
            // ----------------------------------------------

            MessageBox.Show("Done!");
        }

        private void Users_Load(object sender, EventArgs e)
        {
            userInfoLoader();
        }

        public void userInfoLoader()
        {
            this.txtUserName.Text = DiaryProject.Properties.Settings.Default.userName;
            this.txtPassword.Text = DiaryProject.Properties.Settings.Default.userPass;
            // ----------------- Load user pic ------------------
            string df;
            df = Application.StartupPath + "\\data\\userPics\\1.jpg";
            this.pictureBox1.Load(df);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            this.pictureBox1.Load(fn);

        }
    }
}
