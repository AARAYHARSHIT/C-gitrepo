using System;
using System.IO;

class Program
{
    static void Main()
    {
        /*
            WRITE TEXT INTO FILE
        */

        File.WriteAllText("data.txt", "Hello File Handling!");

        Console.WriteLine("File Created");
    }
}
