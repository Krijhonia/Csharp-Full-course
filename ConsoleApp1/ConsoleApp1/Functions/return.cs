// Return type functions in csharp
public class Program
{
    public static void Main()
    {
        int sum = addNumbers(10,20);
        Console.WriteLine($"The sum of the numbers is: {sum}");
    }
    public static int addNumbers(int a ,int b)
    {
        return a + b;
    }
}