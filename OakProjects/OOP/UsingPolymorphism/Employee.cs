using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingPolymorphism
{
    public class Employee
    {
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; }
        public double EmployeeSalary { get; set; }

        public void SetValues(int ID, string Name)
        {
            EmployeeId = ID;
            EmployeeName = Name;
        }

        public void SetValues(int ID, string Name, double Salary)
        {
            EmployeeId = ID;
            EmployeeName = Name;
            EmployeeSalary = Salary;    
        }
    }
}
