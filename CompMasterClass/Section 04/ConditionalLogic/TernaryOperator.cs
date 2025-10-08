using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLogic
{
    internal class TernaryOperator
    {
        static void Main(string[] args)
        {
            int age = 20;
            String status;
            status = (age < 18) ? "Under age" : "Senior";
            Console.WriteLine(status);

            string nationality = "French";
            string isFrench;
            isFrench = (nationality == "French") ? "True" : "False";
            Console.WriteLine(isFrench);
            int years = 30;
            string userStatus;
            userStatus = (years < 18) ? "Minor" : "Adult";
            Console.WriteLine(userStatus);
        }
    }
}
