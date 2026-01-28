using System;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        int num = 0;
        test(out num);
        Console.WriteLine(num);
    }
    public static void test(out int num)
    {
        num = 5;
    }
}