using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee: Human
    {
        protected string Position { get; set; }
        public double Salary { get; set; }

        public void SetValues()
        {
            Name = "Godfrey";
            ID = 1;
            Gender = 'M';
            Age = 30;
        }
    }
}
