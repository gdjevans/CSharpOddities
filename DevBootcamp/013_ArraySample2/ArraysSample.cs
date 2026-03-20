using System; 
class Program 
{ 
	static void Main() 
	{ 
		// Sample - Arrays 2
		int[,] array2DDeclaration = new int[4, 2];
		int[,,] array3DDeclaration = new int[4, 2, 3];

		// Two-dimensional array.
		int[,] array2DInitialization =  { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

		// Three-dimensional array.
		int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
										{ { 7, 8, 9 }, { 10, 11, 12 } } };
		// Accessing 2 dimensional array elements
		System.Console.WriteLine(array2DInitialization[0, 0]);
		System.Console.WriteLine(array2DInitialization[0, 1]);
		System.Console.WriteLine(array2DInitialization[1, 0]);
		System.Console.WriteLine(array2DInitialization[1, 1]);
		System.Console.WriteLine(array2DInitialization[3, 0]);
		System.Console.WriteLine(array2DInitialization[3, 1]);

		// Accessing 3 dimensional array elements
		System.Console.WriteLine(array3D[1, 0, 1]);
		System.Console.WriteLine(array3D[1, 1, 2]);
	} 
}
