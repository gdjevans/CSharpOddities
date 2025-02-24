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
    }
}
