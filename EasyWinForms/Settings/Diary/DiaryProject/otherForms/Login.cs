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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            userInfoLoader();
        }

        public void userInfoLoader()
        {
            this.label3.Text = DiaryProject.Properties.Settings.Default.userName;
            // ----------------- Load user pic ------------------
            string df;
            df = Application.StartupPath + "\\data\\userPics\\1.jpg";
            this.pictureBox1.Load(df);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't let the door hit ya on the way out!");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == " " || this.txtPassword.TextLength == 0)
            {
                MessageBox.Show("Password field is empty, you feeling okay?");
                return;
            } 
            if (this.txtPassword.Text == DiaryProject.Properties.Settings.Default.userPass)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Password ain't good man, you sure you type good?");
            }
        }
    }
}
