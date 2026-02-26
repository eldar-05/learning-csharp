using System;

public class Citizen
{
    public string Name;
    public int Age;
    public string Area;

    public Citizen(string name, int age, string area)
    {
        Name = name;
        Age = age;
        Area = area;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Area: {Area}");
    }
}

class Program
{
    static void Main()
    {
        // 1) opject array
        Citizen[] citizens = new Citizen[1000];
        for (int i = 0; i < 1000; i++)
        {
            citizens[i] = new Citizen("User" + i, 18 + (i % 50), "Area" + (i % 10));
        }

        // 2) array of value
        int[] numbers = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            numbers[i] = i;
        }
        citizens[7].ShowInfo();
        Console.ReadLine();
    }
}
