using System;

class Program
{
    static void Main()
    {
        // 1. Setup UI
        Console.Title = "C# User Profile System";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();

        Console.WriteLine("--- WELCOME TO THE SYSTEM ---");
        Console.ResetColor(); // Reset to default colors for input

        // 2. Getting String Input (Basic)
        Console.Write("\nEnter your full name: ");
        var fullName = Console.ReadLine();

        // 3. Getting Numeric Input (Advanced)
        // We use int.TryParse to prevent the program from crashing if the user types a letter
        int age;
        while (true) 
        {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            
            if (int.TryParse(ageInput, out age)) break; // Valid number! Exit loop.
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.ResetColor();
        }

        // 4. Using ReadKey for a "Press any key" experience
        Console.WriteLine("\nThank you. Press any key to generate your profile...");
        Console.ReadKey();

        // 5. Outputting with String Interpolation ($)
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("*******************************");
        Console.WriteLine($"PROFILE CREATED: {fullName.ToUpper()}");
        Console.WriteLine($"AGE: {age} years old");
        Console.WriteLine($"STATUS: {(age >= 18 ? "Adult" : "Minor")}");
        Console.WriteLine("*******************************");
        Console.ResetColor();

        // Keep console open
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}