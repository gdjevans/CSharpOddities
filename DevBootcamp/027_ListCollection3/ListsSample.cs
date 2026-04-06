using System;
using System.Collections.Generic;
class Program 
{ 
	static void Main() 
	{ 
		// Sample 1 - List Collection - IndexOf
		var names = new List<string> { "Joe", "Anna", "Phillip", "Maria", "Bill" };
		var index = names.IndexOf("Felipe");
		if (index != -1)
		{
			Console.WriteLine($"The name {names[index]} is at index {index}");
		}
		var notFound = names.IndexOf("Not Found");
		Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
		// Sample 2 - Sort the list	
		names.Sort();
		foreach (var name in names)
		{
			Console.WriteLine($"Hello {name.ToUpper()}!");
		}
	} 
}
