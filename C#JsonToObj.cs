

using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        
        string json = @"{""FirstName"": ""Shunmuga"", ""LastName"": ""Priya""}";

     
        var myInfo = JsonSerializer.Deserialize<myInfo>(json);

       
        if (myInfo != null)
        {
            Console.WriteLine($"Hi I am {myInfo.FirstName} {myInfo.LastName}");
        }
        else
        {
            Console.WriteLine("Failed to deserialize JSON.");
        }

        Console.ReadLine();
    }
}

public class myInfo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
