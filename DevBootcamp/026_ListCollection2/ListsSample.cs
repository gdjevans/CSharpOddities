using System;
using System.Collections.Generic;
class Program 
{ 
	static void Main() 
	{ 
		// Sample - List Collection
		var names = new List<string> { "Joe", "Anna", "Phillip" };
		names.Add("Maria");
		names.Add("Bill");
		names.Remove("Anna");
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}

		Console.WriteLine($"My name is {names[0]}.");
		Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
		Console.WriteLine($"The list has {names.Count} people in it");
	} 
}
