using System;
public static class prgm
{
    public static string Reverse(this string str)
    {
        char[] Arr = str.ToCharArray();
        Array.Reverse(Arr);
        return new string(Arr);
    }

    public static bool Palindrome(this string str)
    {
        string reversed = str.Reverse();
        return str.Equals(reversed);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
       string a = "madam";
        string reversed = a.Reverse();
        Console.WriteLine($"Reversed string: {reversed}"); 
        bool Palindrome = a.Palindrome();
        Console.WriteLine($"Is palindrome: {Palindrome}"); 
        string nonPalindrome = "hello";
        bool isNonPalindrome = nonPalindrome.Palindrome();
        Console.WriteLine($"Is {nonPalindrome} a palindrome: {isNonPalindrome}"); 
    }
}
