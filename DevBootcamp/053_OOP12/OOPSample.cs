using System;

// Base class
public class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine("The vehicle is started.");
    }

    public void Stop()
    {
        Console.WriteLine("The vehicle is stopped.");
    }
}

// Derived class
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("The car is accelerating.");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Car class
        Car myCar = new Car();

        // Setting values for the inherited properties
        myCar.Brand = "Toyota";
        myCar.Year = 2022;

        // Setting values for the properties specific to the Car class
        myCar.NumberOfDoors = 4;

        // Calling methods from the base class
        myCar.Start();
        myCar.Stop();

        // Calling methods from the derived class
        myCar.Accelerate();
    }
}