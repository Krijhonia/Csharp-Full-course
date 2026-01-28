// Password checker in Csharp

Console.Write("Enter your password");
string password = Console.ReadLine();

Console.Write("Enter your password again");
string passwordc = Console.ReadLine();

if(!password.Equals(string.Empty))
{
    if(!passwordc.Equals(string.Empty)){

        if(password.Length >= 8 && passwordc.Length >= 8)
        {
            if (password.Equals(passwordc))
            {
                Console.WriteLine("Password matched");
            }
            else
            {
                Console.WriteLine("Password doesn't matched");
            }  
        }
        else
        {
            Console.WriteLine("Please enter a password of atleast 8 characters or more");
        }
    }
    else
    {
        Console.WriteLine("Please write a password confirmation");
    } 
}
else
{
    Console.WriteLine("Please enter a password");
}

Console.ReadLine();