using System;
class Program 
{ 
	static void Main() 
	{ 
		// Sample - Funcitonal Programming
		object someObject = "Hello, pattern matching!";
		if (someObject is string stringValue)
		{
			Console.WriteLine($"The object is a string: {stringValue}");
		}
		else if (someObject is int intValue)
		{
			Console.WriteLine($"The object is an integer: {intValue}");
		}
		else
		{
			Console.WriteLine("The object is of an unknown type.");
		}
	} 
}
