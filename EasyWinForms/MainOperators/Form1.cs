using System.Windows.Forms;

namespace MainOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int result;
            int.TryParse(this.textBox1.Text, out firstNumber);
            int.TryParse(this.textBox2.Text, out secondNumber);
            result = firstNumber + secondNumber;
            this.textBox3.Text = result.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int result;
            int.TryParse(this.textBox1.Text, out firstNumber);
            int.TryParse(this.textBox2.Text, out secondNumber);
            result = firstNumber - secondNumber;
            this.textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int result;
            int.TryParse(this.textBox1.Text, out firstNumber);
            int.TryParse(this.textBox2.Text, out secondNumber);
            result = firstNumber * secondNumber;
            this.textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result;
            double.TryParse(this.textBox1.Text, out firstNumber);
            double.TryParse(this.textBox2.Text, out secondNumber);
            result = firstNumber / secondNumber;
            this.textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int.TryParse(this.textBox5.Text, out firstNumber);
            int.TryParse(this.textBox4.Text, out secondNumber);
            if (firstNumber > secondNumber)
            {
                MessageBox.Show("First Number is greater than Second Number!!");
            }
            else if  (firstNumber < secondNumber)
            {
                MessageBox.Show("First Number is smaller than Second Number!!");
            }
            else
            {
                MessageBox.Show("First Number is equal to Second Number!!");
            }
        }
    }
}
