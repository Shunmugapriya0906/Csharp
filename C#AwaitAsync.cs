using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting the operation");
        string res = await LongOperation();
        Console.WriteLine($"Output: {res}");
        Console.WriteLine("operation completed!!");
    }
    public static async Task<string> LongOperation()
    {
        Console.WriteLine("Long Operation is On");
        await Task.Delay(6000); 
        return "Operation Over !!";
    }
}
