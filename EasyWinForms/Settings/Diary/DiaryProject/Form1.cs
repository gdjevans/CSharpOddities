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
            // ---------------- Populate Sidebar Clock ---------------------
            getTime();
            // -------------------------------------------------------------
            // -------- Populate Sidebar Calendar with System Date ---------
            getCalendar();
            // -------------------------------------------------------------
            this.lblVersion.Text = Application.ProductVersion;
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
    }
}
