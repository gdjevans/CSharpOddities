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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            this.lblCompanyName.Text = Application.CompanyName;
            this.lblProductName.Text = "Product Name: " + Application.ProductName;
            this.lblVersion.Text = "Version: " + Application.ProductVersion;
            // ----------------------- Load From Settings ----------------------------
            this.lblDesignerName.Text = "Designer: " + DiaryProject.Properties.Settings.Default.designerName;
            this.lblProgammerName.Text = "Programmer: " + DiaryProject.Properties.Settings.Default.programmerName;
            this.lblCopyrightYear.Text = DiaryProject.Properties.Settings.Default.copyright;
            // -----------------------------------------------------------------------
        }
    }
}
