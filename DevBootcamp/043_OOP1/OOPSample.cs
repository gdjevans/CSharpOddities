using System;
// Definition of the Car class
public class Car
{
    // Attributes or fields
    public string Make;
    public string Model;
    public int Year;

    // Behaviors or methods
    public void Start()
    {
        Console.WriteLine("The car is started.");
    }

    public void Drive()
    {
        Console.WriteLine("The car is in motion.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Car class
        Car myCar = new Car();

        // Setting values for the attributes
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2022;

        // Accessing attributes and invoking methods
        Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}.");
        myCar.Start();
        myCar.Drive();
    }
}
