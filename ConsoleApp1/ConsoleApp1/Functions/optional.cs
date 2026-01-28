using System;

public class Program
{
    // The Main method is the "Entry Point" where execution starts
    public static void Main()
    {
        // You MUST call functions inside a method like Main
        Users("Sharma");         // Uses default: Mr/Mrs
        Users("Ace", "Dr.");     // Uses provided: Dr.
    }

    // The function is defined inside the class, but outside of Main
    public static void Users(string name, string title = "Mr/Mrs") // The title parameter in this function is a optional parameter
    {
        Console.WriteLine($"Recipient: {title} {name}");
    }
}