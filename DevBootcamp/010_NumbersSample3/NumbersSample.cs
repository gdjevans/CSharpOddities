using System; 
class Program 
{ 
	static void Main() 
	{ 
		// Sample 1
		decimal min = decimal.MinValue;
		decimal max = decimal.MaxValue;
		Console.WriteLine($"The range of the decimal type is {min} to {max}");

		// Sample 2
		double a = 1.0;
		double b = 3.0;
		Console.WriteLine(a / b);

		decimal c = 1.0M;
		decimal d = 3.0M;
		Console.WriteLine(c / d);
	} 
}
