using System;
class Program
{
    static void Main()
    {
        int number = 3;
        switch (number)
        {
            case 1:
                Console.WriteLine("You entered one.");
                break;
            case 2:
                Console.WriteLine("You entered two.");
                break;
            case 3:
                Console.WriteLine("You entered three.");
                break;
            default:
                Console.WriteLine("You entered a number outside the range of 1 to 3.");
                break;
        }
    }
}


