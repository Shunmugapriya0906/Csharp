using System;
using System.Linq;
namespace App{
    class array{
        static void Main(string[]args){
            string[] fruits={"apple","Grapes","Cherry","Guava"};
               Array.Sort(fruits);
             Console.WriteLine(fruits[2]);
             fruits[1]="pineapple";
              Console.WriteLine(fruits[1]);
              Console.WriteLine(fruits.Length);
              foreach(string i in fruits){
                Console.WriteLine(i);
              }
             int[] num={2,1,9,6};
              Console.WriteLine(num.Max());
              Console.WriteLine(num.Min());
              Console.WriteLine(num.Sum());

        }
    }
}