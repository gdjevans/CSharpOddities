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
    }
}
