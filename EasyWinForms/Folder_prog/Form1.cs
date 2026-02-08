using static System.Net.Mime.MediaTypeNames;

namespace Folder_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // System.IO.Directory.CreateDirectory("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Folder_prog\\" + this.textBox1.Text);
            int i;
            for (i = 0; i < 10; i++)
            {
                System.IO.Directory.CreateDirectory("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Folder_prog\\" + i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Boolean r;
            r = System.IO.Directory.Exists("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Folder_prog\\Test");
            if (r == true)
            {
                System.IO.Directory.Delete("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Folder_prog\\Test");
            }
            else
            {
                MessageBox.Show("Folder does not exist");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean r;
            r = System.IO.Directory.Exists("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Folder_prog\\Test");
            if (r == true)
            {
                MessageBox.Show("Folder exists");
            }
            else
            {
                MessageBox.Show("Folder does not exist");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.Directory.Move("F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Folder_prog\\Test", "F:\\Projects\\TutzProjectz2022\\CSharpOddities\\EasyWinForms\\Folder_prog\\TestMove\\Test");
        }
    }
}
