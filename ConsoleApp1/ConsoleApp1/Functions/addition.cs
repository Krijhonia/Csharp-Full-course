// Interactive addition
public class Program
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();
        int num1 = int.Parse(input1);

        Console.Write("Enter the second Number: ");
        string input2 = Console.ReadLine();
        int num2 = int.Parse(input2);

        int result = addNumbers(num1,num2);

        Console.WriteLine($"The sum of {num1} + {num2} is : {result}");
    }

    public static int addNumbers(int num1 ,int num2)
    {
        return num1 + num2;
    }
}