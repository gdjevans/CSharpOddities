using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettingsPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsPro.Properties.Settings.Default.combo_index = this.comboBox1.SelectedIndex;
            SettingsPro.Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Int32 i;
            i = SettingsPro.Properties.Settings.Default.combo_index;
            this.comboBox1.SelectedIndex = i;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float f;
            float.TryParse(this.textBox1.Text, out f);

            SettingsPro.Properties.Settings.Default.markNum = f;
            SettingsPro.Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = SettingsPro.Properties.Settings.Default.markNum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SettingsPro.Properties.Settings.Default.checkedState = this.checkBox1.Checked;
            SettingsPro.Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.checkBox1.Checked = SettingsPro.Properties.Settings.Default.checkedState;
        }
    }
}
