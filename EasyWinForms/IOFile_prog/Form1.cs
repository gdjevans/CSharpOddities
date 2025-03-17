namespace IOFile_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IOFile_prog\\info.txt", this.textBox1.Text);
            MessageBox.Show("Saved File!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.IO.File.ReadAllText("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IOFile_prog\\info.txt");
            MessageBox.Show("File Opened!");
        }
    }
}
