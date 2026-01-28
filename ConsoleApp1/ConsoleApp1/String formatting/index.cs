// --- String formatting in C# ---    

// 1. Initialize data (Strings for names, Doubles for prices)
string item1 = "Apple";
string item2 = "Banana";
double p1 = 1.2;
double p2 = 0.5;

// 2. Print the Header Row
// -10: Left-aligns "Item" in a 10-character wide block
// 8:   Right-aligns "Price" in an 8-character wide block
Console.WriteLine($"{"Item", -10} | {"Price", 8}");

// 3. Print a visual separator
Console.WriteLine("--------------------------");

// 4. Print the Data Rows using Interpolated Strings ($)
// {item1, -10}: Displays the name, left-aligned (width 10)
// {p1, 8:C}: Displays the price, right-aligned (width 8) AND formatted as Currency (:C)
Console.WriteLine($"{item1, -10} | {p1, 8:C}");
Console.WriteLine($"{item2, -10} | {p2, 8:C}");