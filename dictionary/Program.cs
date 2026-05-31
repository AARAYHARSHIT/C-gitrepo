using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /*
            DICTIONARY:
            Stores data in key-value pairs.
        */

        Dictionary<int, string> students =
            new Dictionary<int, string>();

        students.Add(101, "Harshit");
        students.Add(102, "Rahul");

        foreach (var item in students)
        {
            Console.WriteLine(
                item.Key + " : " + item.Value
            );
        }
    }
}
