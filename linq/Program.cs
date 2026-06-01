using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        /*
            LINQ:
            Used for querying/filtering data.
        */

        var result = numbers.Where(n => n > 25);

        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }
}