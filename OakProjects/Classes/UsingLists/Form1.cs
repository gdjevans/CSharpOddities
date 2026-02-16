using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeeList = new List<Employee>(); 
        
        public List<Employee> fillList()
        {
            employeeList.Clear();
            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Charl";
            employee1.Surname = "Dikin";
            employeeList.Add(employee1);
            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Barry";
            employee2.Surname = "Chuckle";
            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Esta";
            employee3.Surname = "VanOrten";
            return employeeList;
        } 

        List<Days> comboList = new List<Days>();


        private void Form1_Load(object sender, EventArgs e)
        {
            Days day1 = new Days();
            day1.ID = 1;
            day1.TextValue = "Sunday";
            comboList.Add(day1);
            Days day2 = new Days();
            day2.ID = 2;
            day2.TextValue = "Monday";
            comboList.Add(day2);
            Days day3 = new Days();
            day3.ID = 3;
            day3.TextValue = "Tuesday";
            comboList.Add(day3);
            Days day4 = new Days();
            day4.ID = 4;
            day4.TextValue = "Wednesday";
            comboList.Add(day4);
            Days day5 = new Days();
            day5.ID = 5;
            day5.TextValue = "Thursday";
            comboList.Add(day5);
            Days day6 = new Days();
            day6.ID = 6;
            day6.TextValue = "Friday";
            comboList.Add(day6);
            Days day7 = new Days();
            day7.ID = 7;
            day7.TextValue = "Saturday";
            comboList.Add(day7);

            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "TextValue";

            dataGridView1.DataSource = comboList;
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (var item in employeeList)
            {
                textBox1.Text += item.ID + item.Name + item.Surname + Environment.NewLine;
            }
            MessageBox.Show("List was filled");
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
