namespace IOInfo_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName;
            fName = "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IOInfo_prog\\info" + this.id_textBox.Text + ".txt";
            if (this.id_textBox.Text == "")
            {
                MessageBox.Show("Please include an ID");
                return;
            }
            if (this.fname_Textbox.Text == "")
            {
                MessageBox.Show("Please enter a full name");
                return;
            }

            System.IO.File.WriteAllText(fName, fname_Textbox.Text);
            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fName;
            fName = "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IOInfo_prog\\info" + this.id_textBox.Text + ".txt";
            if (this.id_textBox.Text == "")
            {
                MessageBox.Show("Please include an ID");
                return;
            }
            if (System.IO.File.Exists( fName ) == false)
            {
                MessageBox.Show("Data does not exist currently.");
                return;
            }
            //System.IO.File.WriteAllText("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IOInfo_prog\\info.txt", fname_Textbox.Text);
            //MessageBox.Show("Data Saved");
            string result = System.IO.File.ReadAllText(fName);
            fname_Textbox.Text = result; 

        }
    }
}
