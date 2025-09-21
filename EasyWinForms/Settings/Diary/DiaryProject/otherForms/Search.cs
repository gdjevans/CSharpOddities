using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryProject.otherForms
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // ---------------------------------------------
            Int32 c;
            c = DiaryProject.Properties.Settings.Default.lastMemoId + 1;
            Int32 i;
            for (i = 1; i <= c; i++)
            {
                this.listBox1.Items.Add(i.ToString()); 
            }
            // ---------------------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiaryProject.otherForms.Memo mf;
            mf = new otherForms.Memo();
            mf.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ---------------------------------------------
            string fn;
            string fn_title;
            string fn_date;
            Int32 lastId;
            Int32.TryParse(this.listBox1.Text, out lastId);
            // ---------------------------------------------
            fn = Application.StartupPath + "\\data\\docs\\" + lastId.ToString() + ".rtf";
            fn_title = Application.StartupPath + "\\data\\docs\\title_" + lastId.ToString() + ".txt";
            fn_date = Application.StartupPath + "\\data\\docs\\date_" + lastId.ToString() + ".txt";
            // ---------------------------------------------
            this.richTextBox1.LoadFile(fn); 
            this.txtTitle.Text = System.IO.File.ReadAllText(fn_title, Encoding.UTF8);
            this.txtDate.Text = System.IO.File.ReadAllText(fn_date, Encoding.UTF8);
            this.txtId.Text = lastId.ToString();
            // ---------------------------------------------
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = this.listBox1.FindStringExact(this.txtSearch.Text);
            this.listBox1.SelectedIndex = i;
        }
    }
}
