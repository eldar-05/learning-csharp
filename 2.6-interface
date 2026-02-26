using System;
using System.Collections.Generic;

public interface ICalculateArea
{
    double GetArea();
}

public class SquarePlot : ICalculateArea
{
    public double Side { get; }

    public SquarePlot(double side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Side * Side;
    }
}

public class TrianglePlot : ICalculateArea
{
    public double BaseLength { get; }
    public double Height { get; }

    public TrianglePlot(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public double GetArea()
    {
        return 0.5 * BaseLength * Height;
    }
}

class Program
{
    static void Main()
    {
        List<ICalculateArea> plots = new List<ICalculateArea>
        {
            new SquarePlot(5),
            new TrianglePlot(4, 6),
            new SquarePlot(3)
        };

        foreach (var plot in plots)
        {
            Console.WriteLine($"Area: {plot.GetArea()}");
        }
    }
}
