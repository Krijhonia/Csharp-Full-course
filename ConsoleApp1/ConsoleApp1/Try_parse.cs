using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        
        if(int.TryParse(input,out int age))
        {
            Console.WriteLine($"In upcoming ten years you will be {age+10}");
        }
        else
        {
            Console.WriteLine("Please enter only numbers");
        }
    }
}