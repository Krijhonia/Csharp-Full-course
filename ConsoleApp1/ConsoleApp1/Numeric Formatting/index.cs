// Numeric Formatting in Csharp

using System.Globalization;

double value = 1000D / 12.34D;


Console.WriteLine(value);
Console.WriteLine(string.Format("{0:0.0}",value));
Console.WriteLine(string.Format("{0:0.00}",value));
Console.WriteLine(string.Format("{0:0.000}",value));

double money = 10D / 3D;
Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture));
Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-GB")));