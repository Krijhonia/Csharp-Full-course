// Times table in Csharp

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} X {1} = {2}",number,i,number*i);
}

