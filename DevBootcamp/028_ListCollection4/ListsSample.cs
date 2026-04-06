using System;
using System.Collections.Generic;
class Program 
{ 
	static void Main() 
	{ 
		// Sample - List Collection - using numbers by using int
		var fibonacciNumbers = new List<int> {1, 1};
		var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
		var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

		fibonacciNumbers.Add(previous + previous2);

		foreach(var item in fibonacciNumbers)
		{
			Console.WriteLine(item);
		} 
	}
}
