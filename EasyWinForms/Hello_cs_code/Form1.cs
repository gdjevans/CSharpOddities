namespace Hello_cs_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello This is my first C# Code and I am really happy!!!");
            MessageBox.Show("2 Line");
            MessageBox.Show("3 Line");
            MessageBox.Show("4 Line");
            MessageBox.Show("5 Line");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am Button 2!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am button 3", "Hello");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            // This line changes the color of my button 2
            button2.BackColor = Color.Green;
            this.BackColor = Color.Red;
            // button4.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Hello I'm a berautiful Textbox";
            this.button3.Text = "Hi Babe!";
            this.Text = "Hi, I love you; Me too!!!!!!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.textBox2.Text = DateTime.Now.ToString();
            //this.textBox2.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = true;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox2.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //this.textBox3.Text = DateTime.Now.ToString();
            this.textBox3.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Do you want to delete?", "Finish", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            MessageBox.Show("Done!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Hello_cs_code\\koala.jpg");
            this.BackgroundImage = Image.FromFile("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Hello_cs_code\\koala.jpg");
            this.tabPage5.BackgroundImage = Image.FromFile("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Hello_cs_code\\koala.jpg");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string msg;
            msg = this.textBox4.Text;
            MessageBox.Show("Hi :" + msg);
            MessageBox.Show("Hi :" + msg + "Welcome Back");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //string a1;
            //string a2;
            //a1 = this.textBox5.Text;
            //a2 = this.textBox6.Text;

            int a1;
            int a2;
            //a1 = Convert.ToInt32(this.textBox5.Text);
            //a2 = Convert.ToInt32(this.textBox6.Text);
            Int32.TryParse(this.textBox5.Text, out a1);
            Int32.TryParse(this.textBox6.Text, out a2);
            int a3;
            a3 = a1 + a2;
            MessageBox.Show(a3.ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\notepad.exe";
            this.process1.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\notepad.exe";
            this.process1.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Int32 uyb;
            Int32.TryParse(this.textBox7.Text, out uyb);

            Int32 age;
            Int32 curr_year;
            curr_year = DateTime.Now.Year;

            age = curr_year - uyb;
            //MessageBox.Show(age.ToString());

            if (age > 35 && age < 50)
            {
                MessageBox.Show("You are middle aged!!!");
            }
            else if (age < 35)
            {
                MessageBox.Show("You are young!!!");
            }
            else
            {
                MessageBox.Show("You are old!!!");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 20; i++)
            {
                MessageBox.Show("I am for loop: my number is: " + i.ToString());
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int mn;
            int.TryParse(this.textBox8.Text, out mn);
            string monthName;
            monthName = "Unknown";


            if (mn == 1)
            {
                //MessageBox.Show("January");
                monthName = "January";
            }
            if (mn == 2)
            {
                //MessageBox.Show("February");
                monthName = "February";
            }
            if (mn == 3)
            {
                //MessageBox.Show("March");
                monthName = "March";
            }
            if (mn == 4)
            {
                //MessageBox.Show("April");
                monthName = "April";
            }
            if (mn == 5)
            {
                //MessageBox.Show("May");
                monthName = "May";
            }
            if (mn == 6)
            {
                //MessageBox.Show("June");
                monthName = "June";
            }
            if (mn == 7)
            {
                //MessageBox.Show("July");
                monthName = "July";
            }
            if (mn == 8)
            {
                //MessageBox.Show("August");
                monthName = "August";
            }
            if (mn == 9)
            {
                //MessageBox.Show("September");
                monthName = "September";
            }
            if (mn == 10)
            {
                //MessageBox.Show("October");
                monthName = "October";
            }
            if (mn == 11)
            {
                //MessageBox.Show("November");
                monthName = "November";
            }
            if (mn == 12)
            {
                //MessageBox.Show("December");
                monthName = "December";
            }

            MessageBox.Show(monthName);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int mn;
            int.TryParse(this.textBox8.Text, out mn);
            string monthNaming;
            monthNaming = string.Empty;

            switch (mn)
            {
                case 1:
                    monthNaming = "January";
                    break;
                case 2:
                    monthNaming = "Febuary";
                    break;
                case 3:
                    monthNaming = "March";
                    break;
                case 4:
                    monthNaming = "April";
                    break;
                case 5:
                    monthNaming = "May";
                    break;
                case 6:
                    monthNaming = "June";
                    break;
                case 7:
                    monthNaming = "July";
                    break;
                case 8:
                    monthNaming = "August";
                    break;
                case 9:
                    monthNaming = "September";
                    break;
                case 10:
                    monthNaming = "October";
                    break;
                case 11:
                    monthNaming = "November";
                    break;
                case 12:
                    monthNaming = "December";
                    break;
                default:
                    monthNaming = "I dunno";
                    break;
            }
            MessageBox.Show(monthNaming);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string monthName;
            string monthNumber;
            monthName = this.textBox9.Text;
            monthNumber = "";
            switch (monthName)
            {
                case "January":
                    monthNumber = "1";
                    break;
                case "Febuary":
                    monthNumber = "2";
                    break;
                case "March":
                    monthNumber = "3";
                    break;
                case "April":
                    monthNumber = "4";
                    break;
                case "May":
                    monthNumber = "5";
                    break;
                case "June":
                    monthNumber = "6";
                    break;
                case "July":
                    monthNumber = "7";
                    break;
                case "August":
                    monthNumber = "8";
                    break;
                case "September":
                    monthNumber = "9";
                    break;
                case "October":
                    monthNumber = "10";
                    break;
                case "November":
                    monthNumber = "11";
                    break;
                case "December":
                    monthNumber = "12";
                    break;
                default:
                    monthNumber = "I dunno";
                    break;
            }
            MessageBox.Show(monthNumber);
        }
    }
}
