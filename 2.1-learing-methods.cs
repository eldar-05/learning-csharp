using System;

class Program
{
    static void Main()
    {
        int districtPopulation = 5000;

        Console.WriteLine("Before: " + districtPopulation);

        UpdatePopulation(ref districtPopulation, 1200);

        Console.WriteLine("After: " + districtPopulation);
        Console.ReadLine(); // у меня консоль пропадает вот по этому оставил
    }

    static void UpdatePopulation(ref int currentPopulation, int growth)
    {
        currentPopulation += growth;
    }
}
