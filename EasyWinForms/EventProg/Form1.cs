namespace EventProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You fine");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Pink;
            //MessageBox.Show("You are on me");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = SystemColors.Menu;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("You pressed the " + e.KeyData.ToString() + " key!");
            this.Text = e.KeyData.ToString();
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                button2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                this.BackColor = Color.LightBlue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }
    }
}
