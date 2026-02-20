using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingEncapulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeName = txtName.Text;
            employeeDetails.EmployeeAge = Convert.ToInt32(txtAge.Text);
            employeeDetails.EmployeePosition = txtPosition.Text;
            frmEmployeeDetail frmDetail = new frmEmployeeDetail();
            frmDetail.label2.Text = employeeDetails.EmployeeName;
            frmDetail.label3.Text = employeeDetails.EmployeeAge.ToString();
            frmDetail.label4.Text = employeeDetails.EmployeePosition;
            frmDetail.ShowDialog();
        }
    }
}
