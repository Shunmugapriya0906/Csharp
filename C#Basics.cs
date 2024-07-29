using System;

namespace APP
{
    public class Program
    {
        public static void Main(){
           Console.WriteLine("Hello World !");
        
        string name="Priya"; 
        int rollno=49;      
        string department="CS";
        rollno=54;
        Console.WriteLine("My Name is " + name +" My Rollno is "+ rollno+ " From "+department+" department");
        string course=department;
        float marks=95.5f;
        int IntMarks= (int)marks;// explicit TypeCasting
        float FloatRollno= rollno;
        Console.WriteLine(IntMarks); // implicit TypeCasting
        Console.WriteLine(FloatRollno);
        Console.WriteLine("Enter UserId");
        int Userid=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The UserId is " + Userid);
         Console.WriteLine(2+5);
        int a=10, b=20;
        Console.WriteLine(Math.Max(a,b));
           Console.WriteLine(Math.Min(a,b));
            Console.WriteLine(Math.Sqrt(45));
             Console.WriteLine(Math.Abs(-88.7));
              Console.WriteLine(Math.Round(56.4));
              bool iseligible=true;
              Console.WriteLine(iseligible);
              int x=9,y=3;
              Console.WriteLine(x<y);    
    }
    }
}
