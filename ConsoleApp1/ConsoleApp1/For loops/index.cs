// For loops in CS

System.Console.Write("Which type of word do you want to repeat? ");
string message = Console.ReadLine();
System.Console.Write("And how many times do you want to repeat that message? ");
int labelCounter = Convert.ToInt32(Console.ReadLine());


if (labelCounter <= 0)
{
    Console.Write("Please enter a value above than 0");
}
else
{
    for (int i = 1 ; i <= labelCounter; i++)
    {
        System.Console.WriteLine(message);
    }
}

