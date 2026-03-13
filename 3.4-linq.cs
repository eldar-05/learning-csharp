using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

class MapItem
{
    public string name;
    public int year;
}

class Program
{
    static void Main()
    {
        List<MapItem> maps = new List<MapItem>
        {
            new MapItem { name = "TSUM", year = 1995 },
            new MapItem { name = "VEFA", year = 2005 },
            new MapItem { name = "ALA-ARCHA", year = 1980 }
        };

        var oldMaps = maps
            .Where(m => m.year < 2000)
            .OrderBy(m => m.name)
            .Select(m => m.name)
            .ToList();

        oldMaps.ForEach(Console.WriteLine);
        Console.ReadLine();
    }
}