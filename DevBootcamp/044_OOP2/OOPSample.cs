using System;

// Base class
class Animal
{
    // Public field
    public string Name;

    // Protected field
    protected int Age;

    // Internal field
    internal string Location;

    // Protected internal field
    protected internal string Habitat;

    // Private field
    private bool isHungry;

    // Constructor
    public Animal(string name, int age, string location, string habitat)
    {
        Name = name;
        Age = age;
        Location = location;
        Habitat = habitat;
        isHungry = true; // Private field can be accessed within the same class
    }

    // Public method
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Location: {Location}, Habitat: {Habitat}");
    }
}

// Derived class
class Cat : Animal
{
    // Constructor
    public Cat(string name, int age, string location, string habitat)
        : base(name, age, location, habitat)
    {
        // Age is accessible because it's protected
        Age += 2;
    }

    // Method
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Cat class
        Cat myCat = new Cat("Whiskers", 3, "Indoor", "House");
        
        // Accessing public members
        myCat.Name = "Whiskers";
        myCat.Location = "Living Room";

        // Accessing protected members
        // Age field is modified in the constructor of Cat class
        // Hence, no direct access here

        // Accessing internal members
        myCat.Location = "Living Room"; // Can access as it's in the same assembly

        // Accessing protected internal members
        myCat.Habitat = "House"; // Can access as it's in the same assembly and Cat is derived from Animal

        // Accessing private members (not directly accessible from outside the class)
        // myCat.isHungry = false; // This will cause a compilation error as isHungry is private

        // Calling public method
        myCat.DisplayDetails();

        // Calling method from derived class
        myCat.MakeSound();
    }
}
