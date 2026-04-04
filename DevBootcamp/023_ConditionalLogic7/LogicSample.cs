using System; 
class Program 
{ 
	static void Main() 
	{ 
		// One for loop can generate the rows:
	/*	for (int row = 1; row < 11; row++)
		{
		Console.WriteLine($"The row is {row}");
		}

		// Another loop can generate the columns:
		for (char column = 'a'; column < 'k'; column++)
		{
		Console.WriteLine($"The column is {column}");
		}
	*/
		// You can nest one loop inside the other to form pairs:
		for (int row = 1; row < 11; row++)
		{
			for (char column = 'a'; column < 'k'; column++)
			{
				Console.WriteLine($"The cell is ({row}, {column})");
			}
		}
	} 
}
