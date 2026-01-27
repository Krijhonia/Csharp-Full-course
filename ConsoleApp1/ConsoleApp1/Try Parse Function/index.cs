// Try parse function in Csharp

bool success = true;


while (success)
{
    Console.WriteLine("Enter a number: ");
    string numInput = Console.ReadLine();

    if (int.TryParse(numInput,out int num))
    {
        success = false;
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Failed to convert! ");
    }
}
Console.ReadLine();
