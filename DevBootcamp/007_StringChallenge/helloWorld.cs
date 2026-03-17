using System; 
class Program 
{ 
	static void Main() 
	{ 
		// Sample - String Challenge
		string songLyrics = "You say goodbye, and I say hello";
		Console.WriteLine(songLyrics.StartsWith("You"));
		Console.WriteLine(songLyrics.StartsWith("goodbye"));

		Console.WriteLine(songLyrics.EndsWith("hello"));
		Console.WriteLine(songLyrics.EndsWith("goodbye"));
	} 
}
