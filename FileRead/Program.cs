using System;
using System.IO;

class Program
{
    static void Main()
    {
        /*
            READ FILE CONTENT
        */

        string text = File.ReadAllText("data.txt");

        Console.WriteLine(text);
    }
}