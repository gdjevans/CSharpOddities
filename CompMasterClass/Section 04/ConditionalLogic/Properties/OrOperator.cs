using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLogic.Properties
{
    internal class OrOperator
    {
        static void Main(string[] args)
        {
            double examScore = 85;
            if(examScore >= 60 || examScore <= 100)
            {
                Console.WriteLine("The student has succeeded!");
            }

            double num = 6;
            if (num % 2 == 0 || num % 3 == 0) 
            {
                Console.WriteLine("The number is even or divisable by 3");
            }
            
            int num = 7;
            if(!(num % 2 == 0))
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
