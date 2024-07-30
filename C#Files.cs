using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string Path = "Demo.txt";
        WriteToFile(Path, "Welcome, All!!");
        string data = ReadFromFile(Path);
        Console.WriteLine($"file Content: {data}");
        DeleteFile(Path);
    }

    public static void WriteToFile(string path, string data)
    {
       
            File.WriteAllText(path, data);
            Console.WriteLine("Success !");
    }

    public static string ReadFromFile(string path)
    {
            string data = File.ReadAllText(path);
            return data;
    }
    public static void DeleteFile(string path)
    {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }

