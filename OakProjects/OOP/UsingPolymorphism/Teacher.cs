using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPolymorphism
{
    public class Teacher: Employee
    {
        public string EmployeePosition { get; set; }

        public void SetValues(int ID, string Name, double Salary, string Position)
        {
            EmployeeId = ID;
            EmployeeName = Name;
            EmployeeSalary = Salary;
            EmployeePosition = Position;    
        }
        public string GetValues()
        {
            string text = "Employee ID: " + EmployeeId + Environment.NewLine;
            text += "Employee Name:" + EmployeeName + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            text += "Employee Position: " + EmployeePosition + Environment.NewLine;
            return text;
        }
    }
}
