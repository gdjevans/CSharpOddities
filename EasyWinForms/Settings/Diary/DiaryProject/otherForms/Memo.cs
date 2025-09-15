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
    }
}
