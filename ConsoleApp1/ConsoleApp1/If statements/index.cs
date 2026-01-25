// If statements

System.Console.WriteLine("What is your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);

if (age >= 18)
{
    System.Console.WriteLine("You are an adult");
}
else if(age<0||age>150)
{
    System.Console.WriteLine("Invalid age");
}