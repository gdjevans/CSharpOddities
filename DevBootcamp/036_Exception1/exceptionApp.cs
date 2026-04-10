using System; 
class Program 
{ 
	static void Main() 
	{ 
		try
		{
			// Code that may throw an exception
			int zeroVal = 0;
			int result = (10 / zeroVal); // Division by zero exception
		}
		catch (Exception ex)
		{
			Console.WriteLine($"An error occurred: {ex.Message}");
		}

	} 
}
