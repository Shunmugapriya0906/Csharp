using System;

namespace App
{
  enum Level
  {
    Easy,
    Medium,
    Hard
  }
  class Program
  {
    static void Main(string[] args)
    {
      Level a = Level.Medium;
      Console.WriteLine($"The Coding Level is {a}");
    }
  }
}