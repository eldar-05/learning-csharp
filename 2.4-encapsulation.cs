using System;

public class Building
{
    private int floorsCount;

    public int FloorsCount
    {
        get => floorsCount;
        set
        {
            if (value >= 1 && value <= 100)
            {
                floorsCount = value;
            }
            else
            {
                Console.WriteLine("something went wrong go again!!!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Building b = new Building();
        b.FloorsCount = 10;   
        Console.WriteLine(b.FloorsCount);
        b.FloorsCount = 150; 
        Console.WriteLine(b.FloorsCount);
        Console.ReadLine();
    }
}
