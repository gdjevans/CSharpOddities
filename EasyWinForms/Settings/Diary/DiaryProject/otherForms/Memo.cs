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
    public partial class Memo : Form
    {
        public Memo()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = this.fontDialog1.Font; 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionColor = this.colorDialog1.Color;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionBackColor = this.colorDialog1.Color;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = this.richTextBox1.SelectionIndent;
            i = i - 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = this.richTextBox1.SelectionIndent;
            i = i + 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            this.btnNew.Enabled = false;
            this.btnSave.Enabled = true;
            // ---------------------------------------------
            Int32 i;
            i = DiaryProject.Properties.Settings.Default.lastMemoId + 1;
            this.txtId.Text = i.ToString();
            // ---------------------------------------------
            this.txtTitle.Text = "";
            this.txtDate.Text = "";
            this.richTextBox1.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnNew.Enabled = true;
            // ---------------------------------------------
            Int32 lastId;
            lastId = DiaryProject.Properties.Settings.Default.lastMemoId;
            lastId = lastId + 1;
            // ---------------------------------------------
            DiaryProject.Properties.Settings.Default.lastMemoId = lastId;
            DiaryProject.Properties.Settings.Default.Save();
            // ---------------------------------------------
            string fn;
            string fn_title;
            string fn_date;
            fn = Application.StartupPath + "\\data\\docs\\" + lastId.ToString() + ".rtf";
            fn_title = Application.StartupPath + "\\data\\docs\\title_" + lastId.ToString() + ".txt";
            fn_date = Application.StartupPath + "\\data\\docs\\date_" + lastId.ToString() + ".txt";
            // ---------------------------------------------
            System.IO.File.WriteAllText(fn_title, this.txtTitle.Text, Encoding.UTF8);
            System.IO.File.WriteAllText(fn_date, this.txtDate.Text, Encoding.UTF8);
            // ---------------------------------------------
            this.richTextBox1.SaveFile(fn);
            MessageBox.Show("Successful Save");
        }

        private void Memo_Load(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.btnSave.Enabled = false;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            DiaryProject.Properties.Settings.Default.lastMemoId = 0;
            DiaryProject.Properties.Settings.Default.Save();
            // ---------------------------------------------
        }

        private void Memo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.btnNew_Click(sender, e);
            }
            // -------------------------
            if (e.KeyCode == Keys.F5)
            {
                this.btnSave_Click(sender, e);
            }
            // -------------------------
        }
    }
}
