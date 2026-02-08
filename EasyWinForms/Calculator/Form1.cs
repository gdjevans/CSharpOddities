namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + ".";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.mainLbl.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "1";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.mainLbl.Text = this.mainLbl.Text + "9";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.operatorLbl.Text = "+";
            if (this.mainLbl.Text != "")
            {
                this.numberDisplayLbl.Text = this.mainLbl.Text;
            }

            this.mainLbl.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.operatorLbl.Text = "-";
            if (this.mainLbl.Text != "")
            {
                this.numberDisplayLbl.Text = this.mainLbl.Text;
            }
            this.mainLbl.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.operatorLbl.Text = "*";
            if (this.mainLbl.Text != "")
            {
                this.numberDisplayLbl.Text = this.mainLbl.Text;
            }
            this.mainLbl.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.operatorLbl.Text = "/";
            if (this.mainLbl.Text != "")
            {
                this.numberDisplayLbl.Text = this.mainLbl.Text;
            }
            this.mainLbl.ResetText();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double firstNum;
            double secondNum;
            double resultNum;
            double.TryParse(this.numberDisplayLbl.Text, out firstNum);
            double.TryParse(this.mainLbl.Text, out secondNum);
            resultNum = 0;

            if (this.operatorLbl.Text == "+")
            {
                resultNum = firstNum + secondNum;
            }

            if (this.operatorLbl.Text == "-")
            {
                resultNum = firstNum - secondNum;
            }

            if (this.operatorLbl.Text == "*")
            {
                resultNum = firstNum * secondNum;
            }

            if (this.operatorLbl.Text == "/")
            {
                resultNum = firstNum / secondNum;
            }

            this.mainLbl.Text = resultNum.ToString();
            this.operatorLbl.ResetText();
            this.numberDisplayLbl.ResetText();
        }
    }
}
