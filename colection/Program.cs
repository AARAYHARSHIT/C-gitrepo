using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /*
            LIST:
            Dynamic collection.
        */

        List<string> names = new List<string>();

        names.Add("Harshit");
        names.Add("Rahul");
        names.Add("Aman");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
