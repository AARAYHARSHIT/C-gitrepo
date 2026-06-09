using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Loading...");

        await DownloadData();

        Console.WriteLine("Completed");
    }

    static async Task DownloadData()
    {
        await Task.Delay(3000);

        Console.WriteLine("Data Downloaded");
    }
}