using System;

public class OuterClass
{
    private int outerField = 10;
    // Nested class
    public class NestedClass
    {
        public void DisplayOuterField(OuterClass outer)
        {
            // Access the private field of the outer class
            Console.WriteLine("Outer field value: " + outer.outerField);
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of the outer class
        OuterClass outerObj = new OuterClass();
        // Create an instance of the nested class
        OuterClass.NestedClass nestedObj = new OuterClass.NestedClass();
        // Call a method of the nested class that accesses the private field of the outer class
        nestedObj.DisplayOuterField(outerObj);
    }
}
