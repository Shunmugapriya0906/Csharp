using System;

public class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public void food()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}
public class Dog : Animal
{

    public Dog(string name) : base(name)
    {
        
    }
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Dog myDog = new Dog("Johny");
        myDog.food(); 
        myDog.Bark(); 
    }
}
