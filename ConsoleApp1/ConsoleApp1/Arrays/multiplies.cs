// Array of multiplies exercise
int num = 7;
int length = 5;
int[] result = new int[length];

for(int i =0 ; i < result.Length; i++)
{
    result[i] =num*(i+1);
}
foreach(var item in result)
{
    Console.WriteLine($"{item}");
}