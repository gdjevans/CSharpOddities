using System;

class ResourceHolder
{
    // Constructor
    public ResourceHolder()
    {
        Console.WriteLine("Constructor: MyClass instance created.");
    }

    // Destructor (Finalizer)
    ~ResourceHolder()
    {
        Console.WriteLine("Destructor: MyClass instance is being finalized.");
    }

    public void DoWork()
    {
        Console.WriteLine("Doing some work...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CreateAndReleaseObject();

        // Force garbage collection
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Main method completed.");
    }

    static void CreateAndReleaseObject()
    {
        ResourceHolder obj = new ResourceHolder();
        obj.DoWork();
        // obj goes out of scope here and is eligible for garbage collection
    }
}
