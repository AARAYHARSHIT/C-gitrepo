using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] marks =
        {
            45, 90, 78, 34, 88, 99
        };

        var toppers =
            marks.Where(m => m >= 80);

        foreach (int m in toppers)
        {
            Console.WriteLine(m);
        }
    }
}
