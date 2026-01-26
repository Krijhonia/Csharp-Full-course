// Switch statements in cs
using System;

System.Console.Write("Enter the number of day in number: ");
int day = Convert.ToInt32(Console.ReadLine);

switch (day)
{
    case 1:
    System.Console.WriteLine("Monday");
    break;
    case 2:
    System.Console.WriteLine("Tue");
    break;
    case 3:
    System.Console.WriteLine("Wed");
    break;
    case 4:
    System.Console.WriteLine("Thurs");
    break;
    case 5:
    System.Console.WriteLine("Fri");
    break;
    case 6:
    System.Console.WriteLine("Sat");
    break;
    case 7:
    System.Console.WriteLine("Sun");
    break;
    default:
    System.Console.WriteLine("Error! Enter a number between 1 to 7");
    break;

}
