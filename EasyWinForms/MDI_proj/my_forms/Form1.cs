namespace MDI_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.MdiParent = this;
            backup.BackColor = Color.YellowGreen;
            backup.ShowIcon = false;
            backup.MaximizeBox = false;
            backup.MinimizeBox = false;
            //----------------------------
            backup.label2.Text = "2026";
            backup.label2.BackColor = Color.Aquamarine;
            //----------------------------
            backup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.MdiParent = this;
            set.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MDI_proj.my_forms.test_form test = new MDI_proj.my_forms.test_form();
            test.Show();
               
        }
    }
}
