namespace IO_file_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.IO.File.Copy("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IO_file_prog\\koala.jpg", "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IO_file_prog\\ToFolder\\koala.jpg", true);
            this.openFileDialog1.ShowDialog();
            string fileName;
            fileName = this.openFileDialog1.FileName;
            System.IO.File.Copy(fileName, "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IO_file_prog\\ToFolder\\koala.jpg", true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fileName;
            fileName = this.openFileDialog1.FileName;
            if (System.IO.File.Exists("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IO_file_prog\\ToFolder\\koala.jpg") == true);
            {
                System.IO.File.Delete("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IO_file_prog\\ToFolder\\koala.jpg");
            }
            System.IO.File.Move(fileName, "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IO_file_prog\\ToFolder\\koala.jpg");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fileName;
            fileName = this.openFileDialog1.FileName;
            System.IO.File.Delete(fileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string r;
            r = System.IO.File.Exists("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\IO_file_prog\\ToFolder\\koala.jpg").ToString();
            if (r == "True")
            {
                MessageBox.Show("I can see your file!!");
            }
            else 
            { 
                MessageBox.Show("File not here..?"); 
            }
            //MessageBox.Show(r);

        }
    }
}
