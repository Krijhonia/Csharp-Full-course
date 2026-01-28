// Odd even split

List<int> even = new List<int>();
List<int> odd = new List<int>();

for(int i=0 ; i<=20 ; i++)
{
    if (i % 2 == 0)
    {
        even.Add(i);
    }
    else
    {
        odd.Add(i);
    }
}
Console.WriteLine("Printing even numbers: ");
foreach(var item in even)
{
    Console.Write($"{item} ");
}
Console.WriteLine(Environment.NewLine + "Printing odd numbers: ");
foreach(var item in odd)
{
    Console.Write($"{item} ");
}
Console.ReadLine();