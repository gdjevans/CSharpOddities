namespace Combo_Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                this.comboBox1.Items.Add(this.textBox1.Text);
                this.itm_count_lbl.Text = this.comboBox1.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("You can't enter an empty name!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int si;
            si = this.comboBox1.SelectedIndex;
            this.comboBox1.Items.RemoveAt(si);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index_label2.Text = comboBox1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.itm_count_lbl.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int foundIndex;
            foundIndex = this.comboBox1.FindStringExact(this.textBox2.Text);
            
            if (foundIndex == -1)
            {
                MessageBox.Show("Not Found, Try Again");
            }
            else
            {
                this.comboBox2.SelectedIndex = foundIndex;
            }
        }
    }
}
