using System;

namespace HelloWorld
{
    class HomeWork1
    {
        static void Main(string[] args)
        {
            //practice 1.2
            const double TAX_RATE = 0.13;
            String districtName = "Leninsky District";
            int buildingCount = 154;
            double totalArea = 2500.45;

            String id;
            int population;
            bool isEcoFriendly;
            decimal averageIncome;

            //practice 1.3
            int a = 10;
            int b = 3;
            double result = (double)a / b;
            Console.WriteLine("Result of division: " + result);

            bool hasWater = true;
            bool hasGas = false;
            bool isReadyForSale = hasWater && hasGas;
            Console.WriteLine(isReadyForSale);

            Console.WriteLine("Area :");
            double area = Console.Read();
            Console.ReadLine();

            Console.WriteLine("Has water? ");
            bool userHasWater = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Has Gas? ");
            bool userHasGas = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(((userHasGas && userHasWater && area > 1000) ? ("This plot is suitable") : ("This plot is not suitable")));

            //practice 1.4
            Console.WriteLine("Population dencity: ");
            int populationDensity = Console.Read();
            switch (populationDensity)
            {
                case < 100:
                    Console.WriteLine("Low");
                    break;
                case >= 100 and <= 500:
                    Console.WriteLine("Medium");
                    break;
                case > 500:
                    Console.WriteLine("High");
                    break;
                default:
                    Console.WriteLine("What is this? That is not population number!!!");
                    break;
            }

            //thernary operator
            Console.WriteLine((populationDensity > 100) ? ((populationDensity > 500) ? ("High") : ("Medium")) : ("Low"));
        }
    }
}