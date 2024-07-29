using System;
namespace App{
    class method{
       

 static void MyMethod(string fname,int age)
    {
      Console.WriteLine("I  got executed!");
      Console.WriteLine(fname + " Sri " + age);
    }
static int num(int x)
    {
      return 5 + x;
    }
    static void stud(string stud1, string stud2, string stud3)
    {
      Console.WriteLine("The Student Of the year is: " + stud3);
    }
     static int Plus(int x, int y)
    {
      return x + y;
    }

    static double Plus1(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      MyMethod("Ritu",12);
      MyMethod("Priya",22); 
      Console.WriteLine(num(5));
      stud(stud3: "John", stud1: "Ritu", stud2: "Shan");
          int num1 = Plus(9, 12);
      double num2 = Plus1(4.5, 9.66);
      Console.WriteLine("Int: " + num1);
      Console.WriteLine("Double: " + num2);

        }}}
