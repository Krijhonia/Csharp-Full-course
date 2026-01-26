//? Enter the numbers

System.Console.Write("Enter the 1st number: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter the 2nd number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Value of "+numberA+" muliplied by "+numberB+" is: ");

int answer = numberA * numberB;

int actualAnswer = Convert.ToInt32(Console.ReadLine());

if (answer == actualAnswer)
{
    System.Console.WriteLine("Well done the answer was: "+answer);
}
else
{
    System.Console.WriteLine("Close but the answer was wrong");
}