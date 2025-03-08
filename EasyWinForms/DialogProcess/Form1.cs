namespace DialogProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
            this.button1.ForeColor = this.colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();
            string fileName;
            fileName = this.folderBrowserDialog1.SelectedPath;
            if (fileName == "")
            {
                MessageBox.Show("Please select a folder!");
            }
            else
            {
                this.textBox1.Text = fileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.fontDialog1.Font = this.fontDialog1.Font;
            this.Font = this.fontDialog1.Font;
            this.textBox2.Text = this.fontDialog1.Font.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fileName;
            fileName = this.openFileDialog1.FileName;
            this.pictureBox1.Image = Image.FromFile(fileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string fileName;
            fileName = this.saveFileDialog1.FileName;
            this.textBox3.Text = fileName;
        }
    }
}
