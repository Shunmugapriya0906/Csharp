using System;
public class Animal
{    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void sound()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    public override void sound()
    {
        Console.WriteLine($"{Name} barks.");
    }
}
public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void sound()
    {
        Console.WriteLine($"{Name} meows.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal myDog = new Dog("pintuh");
        Animal myCat = new Cat("chintuh");
        myDog.sound();
        myCat.sound(); 
        Animal[] animals = { myDog, myCat };
        foreach (var animal in animals)
        {
            animal.sound(); 
        }
    }
}
