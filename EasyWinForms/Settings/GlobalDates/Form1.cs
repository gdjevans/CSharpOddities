using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.txt_year.Text = g.GetYear(DateTime.Now).ToString();
            this.txt_month.Text = g.GetMonth(DateTime.Now).ToString();
            this.txtDayNo.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.txt_day.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            // -------------------------------------------------
            Int32 m;
            Int32.TryParse(this.txt_month.Text, out m);

            this.lbl_monthName.Text = monthNumToName(m);
            // -------------------------------------------------

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

        private void Form1_Load(object sender, EventArgs e)
        {
            Int32 m;
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            Int32.TryParse(g.GetMonth(DateTime.Now).ToString(), out m);
            this.lblYear.Text = g.GetYear(DateTime.Now).ToString();
            this.lblMonthName.Text = monthNumToName(m);
            this.lblDayDate.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.lblDayName.Text = g.GetDayOfWeek(DateTime.Now).ToString();

            // -------------------------------------------------
            
            // -------------------------------------------------
        }
    }
}
