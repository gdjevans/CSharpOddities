using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create a key-value pair list of names and designations
        var employees = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("Dave", "Developer"),
            new KeyValuePair<string, string>("Jane", "Business Analyst"),
            new KeyValuePair<string, string>("Charlie", "Developer")
        };

        // Using a switch statement, print out all developers
        foreach (var employee in employees)
        {
            switch (employee.Value)
            {
                case "Developer":
                    Console.WriteLine($"{employee.Key} is a Developer");
                    break;
                default:
                    // Do nothing for other designations
                    break;
            }
        }
    }
}
