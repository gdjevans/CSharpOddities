using System;

namespace TypeConversion
{
    class Program
    {
	    static void Main(string[] args)
	    {
            byte b = 1;
            int i = b;

            Console.WriteLine(i);

            int j = 1;
            byte n = j;
            Console.WriteLine(n);

            string number = "1234";
            //int u = (int)number;
            int u = Convert.ToInt32(number);
            Console.WriteLine(u);

            try
            {
                string number = "1234";
                //byte o = (byte)number;
                byte o = Convert.ToByte(number);
                Console.WriteLine(o);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            try
            {
                string str = "true";
                bool l = Convert.ToString(str);
                Console.WriteLine(l);
            }
            catch (Exception)
            {
                Console.WriteLine("The value couldn't be converted to boolean");
            }

        }
    }
}

