using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLogic
{
    internal class LogiOps
    {
        static void Main(string[] args)
        {
            int age = 20;
            if (age > 18)
            {
                Console.WriteLine("Condition is true");
            }
            String gender = "male";
            if (gender == "male")
            {
                Console.WriteLine("Condition is true");
            }
            if(age > 18 && gender == "male")
            {
                Console.WriteLine("Both conditions are true");
            }
        }
    }
}
