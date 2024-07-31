
using System;
using System.Text.Json;

public class MyDate
{
    public int year { get; set; }
    public int month { get; set; }
    public int day { get; set; }
}

public class Lad
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public MyDate dateOfBirth { get; set; }
}

class Program
{
    static void Main()
    {
        var obj = new Lad
        {
            firstName = "Arun",
            lastName = "Karthik",
            dateOfBirth = new MyDate
            {
                year = 1901,
                month = 4,
                day = 30
            }
        };
        
        
        var json = JsonSerializer.Serialize(obj);
        Console.WriteLine(json);
    }
}

