using System; 
class Program 
{ 
	public class CustomException : Exception
	{
		public CustomException(string message) : base(message)
		{
		}
	}
	static void Main() 
	{ 
		try
		{
			throw new CustomException("Custom exception thrown.");
		}
		catch (CustomException ex)
		{
			Console.WriteLine($"Custom exception caught: {ex.Message}");
		}
	} 
}
