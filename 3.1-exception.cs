using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        String filePath = "data.txt";
        String data = "here is a data";
        try
        {
            File.WriteAllText(filePath, data);
            Console.WriteLine("Data was writed succesfully");

            String component = File.ReadAllText(filePath);
            Console.WriteLine(component);

            //using another filepath that is doesnt exist
            String anotherFilePath = "anotherData.txt";
            component = File.ReadAllText(anotherFilePath);
            Console.WriteLine(component);

        } catch (FileNotFoundException ex)
        {
            Console.WriteLine($"WE CAUGHT THE FILENOTFOUND!: {ex.Message}");
        } catch(Exception ex)
        {
            Console.WriteLine($"FileNotFoundEX doent happence but this happened : {ex.Message}");
        }

        Console.ReadLine();
    }
}
