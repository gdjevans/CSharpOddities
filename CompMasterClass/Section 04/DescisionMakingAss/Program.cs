using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescisionMakingAss
{
    internal class Program
    {
        static string GradeMe(int average)
        {
            if (average >= 90)           // 90+ 
                return "Grade A";
            else if (average >= 80)      // [80..90)
                return "Grade B";
            else if (average >= 70)      // [70..80)
                return "Grade C";
            else if (average >= 50)      // [50..70) 
                return "Grade D";
            else                         // less than 50
                return "Grade E";
        }

        static int ReadGrade(string title)
        {
            while (true)
            {
                Console.WriteLine(title);

                int result = 0;

                if (int.TryParse(Console.ReadLine(), out result) &&
                    result >= 0 &&
                    result <= 100)
                    return result;

                Console.WriteLine("Please, try again");
            }
        }

        static void Main(string[] args)
        {
            do
            {
                int medeltal = (ReadGrade("math: ") +
                                ReadGrade("gym: ") +
                                ReadGrade("classroom: ")) / 3;

                Console.WriteLine(GradeMe(medeltal));

                Console.WriteLine("Next grade (Y/N)?");
            }
            while (string.Equals("Y",
                                  Console.ReadLine().Trim(),
                                  StringComparison.OrdinalIgnoreCase));
        }
    }
}
