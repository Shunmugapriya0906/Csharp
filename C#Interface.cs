using System;

public interface IAnimal
{
       string Name { get; set; }
    void sound();
    void food();
}

public class Dog : IAnimal
{
    public string Name { get; set; }
    public Dog(string name)
    {
        Name = name;
    }
    public void sound()
    {
        Console.WriteLine($"{Name} barks.");
    }
    public void food()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}
public class panda : IAnimal
{
    public string Name { get; set; }

    public panda(string name)
    {
        Name = name;
    }
    public void sound()
    {
        Console.WriteLine($"{Name} bo bo.");
    }
    public void food()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IAnimal myDog = new Dog("johny");
        IAnimal mypanda = new panda("Chintuh");
        myDog.sound(); 
        myDog.food();     
        mypanda.sound(); 
        mypanda.food();            
        IAnimal[] animals = { myDog, mypanda };
        foreach (var animal in animals)
        {
            animal.sound(); 
            animal.food();       
        }
    }
}
