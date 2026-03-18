using System;

class Program
{
    static void Main()
    {
        int a = 18;
        int b = 6;
        // Adding
        int c = a + b;
        Console.WriteLine(c);
        // Subtraction:
        c = a - b;
        Console.WriteLine(c);
        // Multiplication
        c = a * b;
        Console.WriteLine(c);
        // Division
        c = a / b;
        Console.WriteLine(c);
        int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
        Console.WriteLine(d);
    }
}