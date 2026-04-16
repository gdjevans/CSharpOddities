using System;

public class Library
{
    private string[] books; // Array to store books

    // Constructor
    public Library(int capacity)
    {
        books = new string[capacity];
    }

    // Indexer property
    public string this[int index]
    {
        get
        {
            // Check if index is valid
            if (index >= 0 && index < books.Length)
            {
                return books[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
        }
        set
        {
            // Check if index is valid
            if (index >= 0 && index < books.Length)
            {
                books[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Create a Library object with capacity for 5 books
        Library library = new Library(5);

        // Add books using indexer
        library[0] = "Book 1";
        library[1] = "Book 2";
        library[2] = "Book 3";
        library[3] = "Book 4";
        library[4] = "Book 5";

        // Access books using indexer
        Console.WriteLine("Book at index 2: " + library[2]);
        Console.WriteLine("Book at index 4: " + library[4]);
    }
}
