using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.len_txtbox.Text = this.string_txtbox.Text.Length.ToString();
        }

        private void string_txtbox_TextChanged(object sender, EventArgs e)
        {
            string t;
            t = this.string_txtbox.Text; 
            this.len_txtbox.Text = t.Length.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.day_txtbox.Text = this.date_txtbox.Text.Substring(0, 2);
            this.month_txtbox.Text = this.date_txtbox.Text.Substring(3, 2);
            //this.year_txtbox.Text = this.date_txtbox.Text.Substring(6, 4);

            Int32 i;
            i = this.date_txtbox.Text.Length;
            this.year_txtbox.Text = this.date_txtbox.Text.Substring(i-4, 4);

            // ----------------------------------------------------------------------------

            Int32 m;
            Int32.TryParse(this.month_txtbox.Text, out m);
            string mn;
            switch (m)
            {
                case 1:
                    mn = "January";
                    break;
                case 2:
                    mn = "Feburary";
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
                    mn = "Oktober";
                    break;
                case 11:
                    mn = "November";
                    break;
                case 12:
                    mn = "December";
                    break;
                default:
                    mn = "The month of idiots";
                    break;
            }
            //---------------------------------------------------------
            this.lbl_MonthName.Text = "- " + mn;
            //---------------------------------------------------------

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Random random = new Random();
            int dateMonth = dt.Month;
            int yearChange = dt.Year;
            int randomMonth = random.Next(1, 12);
            string randomDay = random.Next(1, 28).ToString();

            //lbl_TestValues.Text = dt.ToString();

            if (txt_Age.Text.Length >= 1)
            {
                yearChange = yearChange - Convert.ToInt32(txt_Age.Text) - 1;

                if (randomMonth < dateMonth)
                {
                    yearChange = yearChange + 1;
                    //lbl_TestValues.Text += yearChange.ToString();
                }

                //lbl_TestValues.Text += " " + randomMonth.ToString();

                if (randomDay.Length < 2)
                {
                    randomDay = "0" + randomDay;
                }

                string randomMonthConvert = randomMonth.ToString();

                if (randomMonthConvert.Length < 2)
                {
                    randomMonthConvert = "0" + randomMonthConvert;
                }

                txt_DOB.Text = randomDay + "/" + randomMonthConvert + "/" + yearChange.ToString();

                if (txt_DOB.Text.Length > 0)
                    button3.Text = "Regenerate D.O.B";
            }
            else
            {
                MessageBox.Show("Put in an age. Dumbass.");
            }

        }
    }
}
