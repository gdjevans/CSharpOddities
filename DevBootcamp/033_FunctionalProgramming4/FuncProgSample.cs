using System;
using System.Collections.Generic;
class Program 
{ 
	static void Main() 
	{ 
		// List<string> names = null; // Sample 1
		// Sample 2 - Funcitonal Programming 
		List<string> names = new List<string>  
        {
            "Alice", "Bob", "Charlie","David"
        };
		// Traditional null check
		if (names != null)
		{
			int count = names.Count;
			Console.WriteLine("Name count is  " + count.ToString());
		}
		else
		{
			Console.WriteLine("Names are null");
		}

		// Using null-conditional operator
		int countWithNullConditional = names?.Count ?? 0;
		Console.WriteLine("The null-conditional operator is " + countWithNullConditional.ToString());
	} 
}
