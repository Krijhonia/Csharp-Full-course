// If statements

System.Console.WriteLine("What is your age: ");
string ageInput = Console.ReadLine();
int age = Convert.ToInt32(ageInput);


if(age<0||age>150)
{
    System.Console.WriteLine("Invalid age");
}
else
{
    if (age >= 18 && age <= 25)
    {
    System.Console.WriteLine("Your age is between 18 and 25");
    }
    else if(age >= 26)
    {
     System.Console.WriteLine("Your age is 26 or greater than that");   
    }
    else if(age<0 || age > 150)
    {
        System.Console.WriteLine("Invalid age!");
    }    
}