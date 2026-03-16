using System; 
class Program 
{ 
	static void Main() 
	{ 
		// Sample - Replace Strings
		string sayHello = "Hello World!";
		Console.WriteLine(sayHello);
		sayHello = sayHello.Replace("Hello", "Greetings");
		Console.WriteLine(sayHello);

		// Sample - Upper and Lower Case
		Console.WriteLine(sayHello.ToUpper());
		Console.WriteLine(sayHello.ToLower());
	} 
}
