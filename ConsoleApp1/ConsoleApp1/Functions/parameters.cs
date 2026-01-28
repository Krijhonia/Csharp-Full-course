using System;

public class Program
{
    public static void Main()
    {
        GreetUser("Kunal",20);
    }
    public static void GreetUser(string name,int age)
    {
        Console.WriteLine($"Your name is {name} and you are {age} years old");
    }
}