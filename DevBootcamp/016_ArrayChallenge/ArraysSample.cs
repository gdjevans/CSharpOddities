using System; 
class Program 
{ 
	static void Main() 
	{ 
        // Product List
        string[] products = { "Apple", "Banana", "Milk", "Bread", "Eggs" };
        double[] prices = { 1.0, 0.5, 2.0, 1.5, 2.5 };

        Console.WriteLine("Product List:");
        Console.WriteLine("1. " + products[0] + " - $" + prices[0]);
        Console.WriteLine("2. " + products[1] + " - $" + prices[1]);
        Console.WriteLine("3. " + products[2] + " - $" + prices[2]);
        Console.WriteLine("4. " + products[3] + " - $" + prices[3]);
        Console.WriteLine("5. " + products[4] + " - $" + prices[4]);
        Console.WriteLine();

        // Shopping Cart
        Console.WriteLine("Shopping Cart:");

        int[] cartItems = { 1, 3, 4 };

        double totalCost = prices[cartItems[0] - 1] + prices[cartItems[1] - 1] + prices[cartItems[2] - 1];

        Console.WriteLine(products[cartItems[0] - 1] + " - $" + prices[cartItems[0] - 1]);
        Console.WriteLine(products[cartItems[1] - 1] + " - $" + prices[cartItems[1] - 1]);
        Console.WriteLine(products[cartItems[2] - 1] + " - $" + prices[cartItems[2] - 1]);

        Console.WriteLine("Total Cost: $" + totalCost);
	} 
}
