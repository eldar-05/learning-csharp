using System;
class Program
{
    static void Main()
    {
        List<int> squares = new List<int> {1,2,3,4,5,6};
        List<int> bigSquares = squares.FindAll(x => x > 3);
        foreach (int n in bigSquares)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();
    }
}