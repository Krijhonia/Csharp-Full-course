// Functions in Csharp
using System;
public class Program
{
    public static void Main()
    {
        int sum = addNumbers(10,20);
        Console.WriteLine($"The sum of the number is: {sum}");
    }

    public static int addNumbers(int a,int  b)
    {
       int result = a+b;
       return result; 
    }
}