using System;

namespace HelloWorld
{
    class Program
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
            double area = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Has water? ");
            bool userHasWater = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Has Gas? ");
            bool userHasGas = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(((userHasGas && userHasWater && area > 1000) ? ("This plot is suitable") : ("This plot is not suitable")));

            //practice 1.4
            Console.WriteLine("Population dencity: ");
            int populationDensity = Convert.ToInt32(Console.ReadLine());

            //thernary operator
            if (populationDensity < 100)
            {
                Console.WriteLine("Low");
            }
            else if (populationDensity >= 100 && populationDensity <= 500)
            {
                Console.WriteLine("Medium");
            }
            else
            {
                Console.WriteLine("High");
            }


            //practice 1.5 loops
            bool running = true;
            int count = 0;
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Give me area");
                int user_input_area = Convert.ToInt32(Console.ReadLine());
                if (user_input_area == 0)
                {
                    running = false;
                    break;
                }
                count++;
                sum += user_input_area;
            }
            Console.WriteLine("Total amount " + count);
            Console.WriteLine("Total sum " + sum);
            Console.ReadLine();

        }
    }
}
