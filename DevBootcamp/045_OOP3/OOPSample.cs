using System;

public class Circle
{
    // Constant for PI
    private const double Pi = 3.14159;

    // Field for radius
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area using the constant Pi
    public double CalculateArea()
    {
        return Pi * radius * radius;
    }

    // Main method to demonstrate usage
    public static void Main()
    {
        // Create a new Circle object with a radius of 5 units
        Circle circle = new Circle(5.0);

        // Calculate and display the area of the circle
        Console.WriteLine("Radius: " + circle.radius);
        Console.WriteLine("Area: " + circle.CalculateArea());
    }
}
