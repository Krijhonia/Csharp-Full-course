// string reversing in Csharp

string original = "Hello World!";
string reversed = "0";

//The loop starts from the last index -1
// And goes to the first index which is 0
// i-- for decrementing
for (int i = original.Length -1 ; i >= 0 ; i--)
{
    reversed += original[i];
}
Console.WriteLine(reversed);