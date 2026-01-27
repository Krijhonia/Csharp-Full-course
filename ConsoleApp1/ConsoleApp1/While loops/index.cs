// While loops in Csharp

System.Console.Write("Enter the 1st number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter the 2nd number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Value of "+numberA+" muliplied by "+numberB+" is: ");

int answer = numberA * numberB;
int actualAnswer = 0;


while (answer != actualAnswer)
{
    Console.Write("Enter your answer: ");
    actualAnswer = Convert.ToInt32(Console.ReadLine());

    if (answer != actualAnswer)
    {
        Console.WriteLine("Close ! but the answer was wrong");
    }
}

Console.WriteLine("Well done! The answer was correct");
Console.ReadLine();