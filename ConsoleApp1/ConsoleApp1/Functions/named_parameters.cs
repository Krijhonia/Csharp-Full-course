using System;
public class Program
{
    public static void Main()
    {
        SetDimensions(depth: 5 , height: 20, width: 10); // These are the named parameters in this case
    }

    public static void SetDimensions(int height,int width , int depth)
    {
      Console.WriteLine($"Box is {height} X {width} X {depth}");
    }
}