using System;
namespace App{

    class Animal{
             string color="Black" ;
            String name;
            string type;

            public Animal(){  //constructor
                type="Bear";
            }
    
    static void Main(string[] args){
Animal panda=new Animal();
panda.name="pintuh";
Animal dino=new Animal();
dino.name="chintuh";
Animal tiger=new Animal();
tiger.name="Poochi";
dino.color="Green";
tiger.color="Orange";

Console.WriteLine(panda.color);
Console.WriteLine(dino.color);
Console.WriteLine(tiger.name);
Console.WriteLine(panda.type);
 }
}
}