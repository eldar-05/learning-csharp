using System;

public class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("not registered vehicle is moving");
    }
}

public class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("bus is moving");
    }
}

public class Tram : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("tram is moving");
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle = new Vehicle();
        Vehicle bus = new Bus();
        Vehicle tram = new Tram();

        vehicle.Move();
        bus.Move(); 
        tram.Move();

        Console.ReadLine();
    }
}
