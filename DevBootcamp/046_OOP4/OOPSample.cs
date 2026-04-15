using System;

public class Rectangle
{
    // Private fields
    private double length;
    private double width;

    // Property for length with get and set accessors
    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    // Property for width with get and set accessors
    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    // Property to compute and return the area of the rectangle
    public double Area
    {
        get { return length * width; }
    }

    // Main method to demonstrate usage
}

class Program
{
    public static void Main()
    {
        // Create a new Rectangle object
        Rectangle rectangle = new Rectangle();

        // Set values for length and width using properties
        rectangle.Length = 5.0;
        rectangle.Width = 3.0;

        // Display length, width, and area of the rectangle
        Console.WriteLine("Length: " + rectangle.Length);
        Console.WriteLine("Width: " + rectangle.Width);
        Console.WriteLine("Area: " + rectangle.Area);
    }
}