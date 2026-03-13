using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var areas = new Dictionary<string, double>()
        {
            {"bishkek", 100}, {"osh", 50}, {"isikol", 75}
        };

        Console.Write("name: ");
        string name = Console.ReadLine();
        Console.WriteLine(areas[name]);
        Console.ReadLine();
    }
}