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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = this.textBox1.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.LightGreen;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.LightGreen;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.LightGreen;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!!!");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.LightCoral;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.LightGray;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.checkBox1.Checked.ToString());
            if (checkBox1.Checked)
            {
                MessageBox.Show("You Checked!!");
            }

            if (!checkBox1.Checked)
            {
                MessageBox.Show("You Unchecked!!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.textBox1.Text = this.comboBox1.SelectedIndex.ToString();
            //this.textBox2.Text = this.comboBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item.");
                return;
            }
            this.textBox1.Text = this.comboBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.comboBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item.");
                return;
            }
            this.textBox1.Text = this.listBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.listBox1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item.");
                return;
            }
            this.textBox1.Text = this.listBox1.SelectedIndex.ToString();
            this.textBox2.Text = this.listBox1.Text;
        }
    }
}
