using System; 
class Program 
{ 
	static void Main() 
	{ 
		try
		{
			// Code that may throw an exception
		}
		catch (Exception ex)
		{
			Console.WriteLine($"An error occurred: {ex.Message}");
		}
		finally
		{
			// Cleanup code or final tasks
			Console.WriteLine("Finally block executed.");
		}

	} 
}
