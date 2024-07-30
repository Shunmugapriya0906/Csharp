using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number:");
            string a = Console.ReadLine();
            int num = Convert.ToInt32(a); 
            int res = 100 / num;     

            Console.WriteLine($"100 divided by {num} is {res}.");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Input Format");
            Console.WriteLine($"Exception: {e.Message}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Cannot divide by zero.");
            Console.WriteLine($"Exception: {e.Message}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Input Overflow");
            Console.WriteLine($"Exception: {e.Message}");
        }
        
        finally
        {
            Console.WriteLine("Execution Over!!");
        }

    }
}
