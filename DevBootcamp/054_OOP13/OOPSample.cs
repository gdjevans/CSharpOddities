using System;

// Abstract class
public abstract class Shape
{
    // Abstract method
    public abstract double CalculateArea();

    // Concrete method
    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

// Derived class
public class Circle : Shape
{
    // Properties specific to the Circle class
    public double Radius { get; set; }

    // Implementation of the abstract method
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Circle class
        Circle myCircle = new Circle
        {
            Radius = 5
        };

        // Calling methods from the base class
        myCircle.Display();

        // Calling the abstract method, which is implemented in the derived class
        double area = myCircle.CalculateArea();
        Console.WriteLine($"The area of the circle is: {area}");
    }
}