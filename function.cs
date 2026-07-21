using System;

class Program
{
    static void Main()
    {
        int result = Add(10, 20);

        Console.WriteLine("Sum = " + result);
    }

    /*
        METHOD WITH RETURN TYPE
    */

    static int Add(int a, int b)
    {
        return a + b;
    }
}