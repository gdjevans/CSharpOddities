using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPolymorphism
{
    public class Employee2
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }
        public string EmployeePosition { get; set; }

        public virtual string SetValues(int ID, string Name, double Salary)
        {
            EmployeeId = ID;
            EmployeeName = Name;
            EmployeeSalary = Salary;

            string text = "Employee ID: " + EmployeeId + Environment.NewLine;
            text += "Employee Name:" + EmployeeName + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            return text;
        }
    }
}
