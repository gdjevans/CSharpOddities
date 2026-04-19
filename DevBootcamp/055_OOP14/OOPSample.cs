using System;

// Base class
public class Animal
{
    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }
}

// Derived class
public class Dog : Animal
{
    // Override method
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// Another derived class
public class Cat : Animal
{
    // Override method
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main()
    {
        // Creating instances of different types
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        // Calling the overridden method
        myDog.MakeSound();  // Output: Woof!
        myCat.MakeSound();  // Output: Meow!
    }
}