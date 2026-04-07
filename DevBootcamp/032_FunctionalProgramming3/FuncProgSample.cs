using System;
class Program 
{ 
	static void Main() 
	{ 
		// Sample - Funcitonal Programming - As Operator Casting
		object obj = "Hello";
		string strValue = obj as string; // Using 'as' operator

		if (strValue != null)
		{
			Console.WriteLine($"Casted value: {strValue}"); // Output: Casted value: Hello
		}
		else
		{
			Console.WriteLine("Casting failed");
		}
	} 
}
