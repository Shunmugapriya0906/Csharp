using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string> { "Ammu", "Sabari", "Dharun" };
        Console.WriteLine("Name List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Add("Star");
        names.Remove("Dharun");
        Console.WriteLine("\n Updated Name List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Dictionary<string, int> age = new Dictionary<string, int>
        {
            { "Ammu", 22 },
            { "Sabari", 23},
            { "Dharun", 21 }
        };
        Console.WriteLine("\n ages:");
        foreach (var j in age)
        {
            Console.WriteLine($"{j.Key} is {j.Value} years old.");
        }
        age["Star"] = 20; 
        age.Remove("Ammu"); 
        Console.WriteLine("\n Updated ages:");
        foreach (var j in age)
        {
            Console.WriteLine($"{j.Key} is {j.Value} years old.");
        }
        SortedDictionary<string, int> sortedAge = new SortedDictionary<string, int>
        {
            { "Ammu", 20 },
            { "Raji", 25 },
            { "Charu", 15 },
            {"Anu",21}
        };
        Console.WriteLine("\n Sorted  ages :");
        foreach (var k in sortedAge)
        {
            Console.WriteLine($"{k.Key} is {k.Value} years old.");
        }
        sortedAge["Raghavi"] = 13; 
        sortedAge.Remove("Charu"); 
        Console.WriteLine("\n Updated Sorted ages:");
        foreach (var k in sortedAge)
        {
            Console.WriteLine($"{k.Key} is {k.Value} years old.");
        }

        // LINQ 
        Console.WriteLine("\n Names starting with 'S':");
        var namesWithS = names.Where(name => name.StartsWith("S"));
        foreach (var name in namesWithS)
        {
            Console.WriteLine(name);
        }
    }
}
