using System;
class Program
{
    static void Main()
    {
        double[] areas = { 1, 2, 3, 4, 5, 6};
        int maxIndex = 0;
        for (int i = 1; i < areas.Length; i++)
        {
            if (areas[i] > areas[maxIndex])
            {
                maxIndex = i;
            }
        }
        Console.WriteLine("max: " + maxIndex);
        Console.ReadLine();
    }
}