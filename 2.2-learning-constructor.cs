using System;

public class Citizen
{
    public string Name;
    public int Age;
    public string Area;

    public Citizen(string name, int age, string area)
    {
        this.Name = name;
        this.Age = age;
        this.Area = area;
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
        Citizen citizen1 = new Citizen("Eldar", 19, "Bishkek");
        Citizen citizen2 = new Citizen("Kasym", 21, "Osh");

        citizen1.ShowInfo();
        citizen2.ShowInfo();

        Console.ReadLine();
        //console is hiding fast
    }
}
