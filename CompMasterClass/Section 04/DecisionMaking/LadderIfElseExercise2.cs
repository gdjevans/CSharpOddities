using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    internal class LadderIfElseExercise2
    {
        static void Main(string[] args)
        {
            string day = "Tuesday";
            if (day == "Monday")
            {
                Console.WriteLine("Blues");
            }
            else if (day == "Tuesday")
            {
                Console.WriteLine("Vibes");
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine("Hump");
            }
            else if (day == "Thursday")
            {
                Console.WriteLine("Almost Friday");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("TGIF");
            }
            else if (day == "Saturday")
            {
                Console.WriteLine("Weekend");
            }
            else if (day == "Sunday")
            {
                Console.WriteLine("Weekend Recovery");
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }

            int salary = 80000;
            if (salary < 18200)
            {
                Console.WriteLine("Tax Bracket: No Tax");
            }
            else if (salary >= 18200 && salary < 37000)
            {
                Console.WriteLine("Tax Bracket: Low");
            }
            else if (salary >= 37000 && salary < 90000)
            {
                Console.WriteLine("Tax Bracket: Medium");
            }
            else if (salary >= 90000 && salary < 180000)
            {
                Console.WriteLine("Tax Bracket: High");
            }
            else
            {
                Console.WriteLine("Tax Bracket: Very High");
            }


        }
    }
}
