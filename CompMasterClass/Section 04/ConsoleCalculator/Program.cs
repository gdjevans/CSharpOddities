using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int input_1 = 0;
            try { input_1 = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine("Enter 2nd number");
            int input_2 = 0;
            try {input_2 = Convert.ToInt32(Console.ReadLine());}
            catch(Exception e) { Console.WriteLine(e); }
            
            Console.WriteLine("Enter what ya wanna do :");
            Console.WriteLine("1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division \n");
            int action = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            string sign = "";
            switch (action)
            {
                case 1:
                    {
                        result = input_1 + input_2;
                        sign = "+";
                        break;
                    }
                case 2:
                    {
                        result = input_1 - input_2;
                        sign = "-";
                        break;
                    }
                case 3:
                    {
                        result = input_1 * input_2;
                        sign = "*";
                        break;
                    }
                case 4:
                    {
                        if (input_1 == 0 || input_2 == 0) 
                        { 
                            Console.WriteLine("Can't divide by 0, did you fall over and hit your head, how about trying again?");
                        } else
                        {
                            result = input_1 / input_2;
                            sign = "/";
                        }
                        break;
                    }
                default:
                    Console.WriteLine("That ain't something, what ya doing. Just try again, huh");
                    break;
            }
            Console.WriteLine("Result: {0} {1} {2} = {3}", input_1, sign, input_2, result);
            Console.WriteLine("Do you want to perform another calculation? (Y/N):");
            string response = Console.ReadLine().Trim().ToLower();

            if (response == "N")
            {
                Console.WriteLine("Thank you for using the calculator. Goodbye!");
                return;
            }
            Console.ReadKey();
        }
        
    }
}
