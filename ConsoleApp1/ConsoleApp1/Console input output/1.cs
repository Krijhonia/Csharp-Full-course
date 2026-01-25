using System;

System.Console.WriteLine("Hi my name is Kunal");
System.Console.Write("What is your name: ");
string name = Console.ReadLine();

System.Console.Write("What is your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);


System.Console.WriteLine("Your name is : " +name);
System.Console.WriteLine("And your age is: "+age);


if (age >= 18)
{
    System.Console.WriteLine("You are an adult");
}
