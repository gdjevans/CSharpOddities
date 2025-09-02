using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bye now!", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ---------------- Load Login Form ---------------------
            DiaryProject.otherForms.Login loginForm = new otherForms.Login();
            loginForm.ShowDialog();
            // -------------------------------------------------------------

            // ---------------- Populate Sidebar Clock ---------------------
            getTime();
            // -------------------------------------------------------------
            // -------- Populate Sidebar Calendar with System Date ---------
            getCalendar();
            // -------------------------------------------------------------
            this.lblVersion.Text = Application.ProductVersion;
            // --------------- Populate Background Image -------------------
            Int32 si;
            si = DiaryProject.Properties.Settings.Default.selectedBakImg;
            loadBak(si);
            // -------------------------------------------------------------
            backgroundComboLoader();
            this.comboBox1.SelectedIndex = si;
            // ---------------- Populate Music Combobox --------------------
            musicComboLoader();
            // -------------------------------------------------------------
            // ---------------- Populate Music Combobox --------------------
            //Int32 sm;
            //sm = DiaryProject.Properties.Settings.Default.selectedMusIndex;
            //this.cboMusic.SelectedIndex = sm;
            //musicLoader(sm);
            // -------------------------------------------------------------
            userInfoLoader();
        }

        public void userInfoLoader()
        {
            this.label5.Text = DiaryProject.Properties.Settings.Default.userName;
            // ----------------- Load user pic ------------------
            string df;
            df = Application.StartupPath + "\\data\\userPics\\1.jpg";
            this.pictureBox1.Load(df);
        }

        public void backgroundComboLoader()
        {
            Int32 i;
            for (i = 1; i <= 4; i++)
            {
                this.comboBox1.Items.Add("Image " + i.ToString());
            }
        }

        public void musicComboLoader()
        {
            Int32 i;
            for (i = 1; i <= 2; i++)
            {
                this.cboMusic.Items.Add("Music " + i.ToString());
            }
        }

        public void loadBak(Int32 comboIndex)
        {
            string fn;
            comboIndex = comboIndex + 1;
            fn = Application.StartupPath + "\\data\\pics\\" + comboIndex.ToString() + ".jpg";
            this.BackgroundImage = Image.FromFile(fn);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void getTime()
        {
            this.lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public string monthNumToName(Int32 month_num)
        {
            string mn;
            switch (month_num)
            {
                case 1:
                    mn = "January";
                    break;

                case 2:
                    mn = "February";
                    break;

                case 3:
                    mn = "March";
                    break;

                case 4:
                    mn = "April";
                    break;

                case 5:
                    mn = "May";
                    break;

                case 6:
                    mn = "June";
                    break;

                case 7:
                    mn = "July";
                    break;

                case 8:
                    mn = "August";
                    break;

                case 9:
                    mn = "September";
                    break;

                case 10:
                    mn = "October";
                    break;

                case 11:
                    mn = "November";
                    break;

                case 12:
                    mn = "December";
                    break;

                default:
                    mn = "Unknown";
                    break;
            }
            return mn;
        }

        public void getCalendar()
        {
            Int32 m;
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            Int32.TryParse(g.GetMonth(DateTime.Now).ToString(), out m);
            this.lblYear.Text = g.GetYear(DateTime.Now).ToString();
            this.lblMonthName.Text = monthNumToName(m);
            this.lblDayDate.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.lblDayName.Text = g.GetDayOfWeek(DateTime.Now).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 si;
            si = comboBox1.SelectedIndex;   
            loadBak(si);
            // ------------------- Saving -----------------------
            DiaryProject.Properties.Settings.Default.selectedBakImg = si;
            DiaryProject.Properties.Settings.Default.Save();
            // --------------------------------------------------
        }

        private void cboMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void musicLoader(Int32 comboIndex)
        {
            string fn;
            comboIndex = comboIndex + 1;
            fn = Application.StartupPath + "\\data\\music\\" + comboIndex.ToString() + ".mp3";
            this.axWindowsMediaPlayer1.URL = fn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musicLoader(this.cboMusic.SelectedIndex);
            DiaryProject.Properties.Settings.Default.selectedMusIndex = this.cboMusic.SelectedIndex;
            DiaryProject.Properties.Settings.Default.Save();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiaryProject.otherForms.AboutUs ab_Form = new otherForms.AboutUs();
            ab_Form.MdiParent = this;
            ab_Form.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiaryProject.otherForms.Users users_Form = new otherForms.Users();
            users_Form.MdiParent = this;
            users_Form.Show();
        }
    }
}
