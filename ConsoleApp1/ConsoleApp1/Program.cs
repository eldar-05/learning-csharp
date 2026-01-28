using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            int age = Console.Read();
            String dataOfBirth = age.ToString();
            int let = Convert.ToInt32(dataOfBirth);
            int daysLived = (age * 365 / 13);
            Console.WriteLine(let * 365 / 13);
            Console.WriteLine("Your age is: " + let + " and you have lived " + daysLived);
            */

            byte a = 5;
            for(int i = 0; i < 1; i++)
            {
                a++;
                Console.WriteLine(a);
            }
            /* output: it means it can store only 255 values, after that it will start from 0 again(((
             * 254
             * 255
             * 0
             * 1
             * 2
             * 3
             */

            //decimal


        }
    }
}