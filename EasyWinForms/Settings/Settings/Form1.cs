using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txt_title.Text = Settings.Properties.Settings.Default.co_title;
            this.txt_manager.Text = Settings.Properties.Settings.Default.co_manager;
            this.txt_adv.Text = Settings.Properties.Settings.Default.co_adv;
            this.txt_tel.Text = Settings.Properties.Settings.Default.co_tel;
            this.txt_mob.Text = Settings.Properties.Settings.Default.co_cell;
            this.txt_fax.Text = Settings.Properties.Settings.Default.co_fax;
            this.txt_activity.Text = Settings.Properties.Settings.Default.co_activity;
            this.txt_email.Text = Settings.Properties.Settings.Default.co_email;
            this.txt_site.Text = Settings.Properties.Settings.Default.co_website;
            this.txt_address.Text = Settings.Properties.Settings.Default.co_address;
            this.comboBox1.Text = Settings.Properties.Settings.Default.co_lang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Properties.Settings.Default.co_title = this.txt_title.Text;
            Settings.Properties.Settings.Default.co_manager = this.txt_manager.Text;
            Settings.Properties.Settings.Default.co_adv = this.txt_adv.Text;
            Settings.Properties.Settings.Default.co_tel = this.txt_tel.Text;
            Settings.Properties.Settings.Default.co_cell = this.txt_mob.Text;
            Settings.Properties.Settings.Default.co_fax = this.txt_fax.Text;
            Settings.Properties.Settings.Default.co_activity = this.txt_activity.Text;
            Settings.Properties.Settings.Default.co_email = this.txt_email.Text;
            Settings.Properties.Settings.Default.co_website = this.txt_site.Text;
            Settings.Properties.Settings.Default.co_address = this.txt_address.Text;
            Settings.Properties.Settings.Default.co_lang = this.comboBox1.Text;
            Settings.Properties.Settings.Default.Save();
            MessageBox.Show("Settings Saved!");
        }
    }
}
