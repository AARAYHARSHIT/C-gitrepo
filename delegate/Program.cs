using System;

delegate void MessageDelegate();

class Program
{
    static void Welcome()
    {
        Console.WriteLine("Welcome User!");
    }

    static void Main()
    {
        MessageDelegate msg = Welcome;

        msg();
    }
}
