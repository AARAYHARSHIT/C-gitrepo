using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num);
        }
        catch
        {
            Console.WriteLine("Invalid Input!");
        }
        finally
        {
            Console.WriteLine("Program Finished");
        }
    }
}