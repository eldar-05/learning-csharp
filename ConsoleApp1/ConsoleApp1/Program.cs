using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // ###################  DATA TYPES USAGE #######################
            /*
            Console.WriteLine("Hello World!");
            int age = Console.Read();
            String dataOfBirth = age.ToString();
            int let = Convert.ToInt32(dataOfBirth);
            int daysLived = (age * 365 / 13);
            Console.WriteLine(let * 365 / 13);
            Console.WriteLine("Your age is: " + let + " and you have lived " + daysLived);
            */


            // ###################  BYTE DATA TYPE HOW ITS WORKING #######################

            /* output: it means it can store only 255 values, after that it will start from 0 again(((
             * 254
             * 255
             * 0
             * 1
             * 2
             * 3
             */

            // ###################  LOGICAL OPERATIONS #######################

            bool isCSharpFun = true;
            bool amIGood = false;
            bool isGodExist = true;
            bool isEarthFlat = false;
            // only one
            Console.WriteLine(true | false);
            Console.WriteLine(false | true);
            Console.WriteLine(true | true);
            Console.WriteLine(false | false);
            Console.WriteLine();
            // with ||
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.WriteLine("NO DIFFERENCE \n");

            // ###################  IF  ELSE IN C# #######################
            bool isSunny = true;
            bool isRaining = false;
            bool doingSports = true;
            bool isAtHome = false;
            if (isSunny == true && doingSports != false)
            {
                Console.WriteLine("I am happiest man in the world");
            }
            else if (isRaining == true && isAtHome == true)
            {
                Console.WriteLine("I am sad");
            }
            else if (isRaining == true && isAtHome == false || isRaining == true && doingSports == true)
            {
                Console.WriteLine("I am wet");
            }
            else
            {
                Console.WriteLine("I dont know what is going on here");
            }

            // ###################  TERNARY OPERATION  #######################

            Console.WriteLine((isAtHome ? "I am sad" : "I am happy"));

            // ###################  FOR LOOPS  #######################

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("The value of i is: " + i);
            }

            int j = 10;
            while (j-- > 10)
            {
                Console.WriteLine(j + " hard");
            }

            j = 5;
            do
            {
                Console.WriteLine("this code is running only if j > 10 but in do while loop it run a least once");
                j++;
            } while (j > 10);

            int[] data = { 10, 20, 30, 40, 50 };
            foreach (int part in data)
            {
                Console.WriteLine(part * 2);
            }
        }
    }
}