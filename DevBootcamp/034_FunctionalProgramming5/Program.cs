using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var list = new List<KeyValuePair<string, string>> {
            new KeyValuePair<string, string>("00001", "John"),
            new KeyValuePair<string, string>("00002", "Mary")
        };

        list.ForEach(kvp => Console.WriteLine($"{kvp.Key}: {kvp.Value}"));
    }
}


