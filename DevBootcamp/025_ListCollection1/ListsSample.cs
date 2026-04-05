using System;
using System.Collections.Generic;
class Program 
{ 
	static void Main() 
	{ 
		// Sample - List Collection
		var names = new List<string> { "Joe", "Anna", "Phillip" };
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}
	} 
}
