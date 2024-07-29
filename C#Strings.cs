using System;
namespace App
{
public class prgm1{
    public static void Main(string[] args){
    string a="Hello! This is me";
    string b=" Welcome You!!";
    Console.WriteLine(a.Length);
    Console.WriteLine(a.ToUpper());
    string c=string.Concat(a,b);
    Console.WriteLine(c);
   string d = $"Hii {a} {b}";
    Console.WriteLine(d);
    Console.WriteLine(a[7]);
    Console.WriteLine(a.IndexOf("e"));
    int e= a.IndexOf("i");
    string f=a.Substring(e);
    Console.WriteLine(f);
    Console.WriteLine("This is \" important \"");
    
}
}
}