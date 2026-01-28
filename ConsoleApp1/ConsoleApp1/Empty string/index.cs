// --- Understanding Empty Strings ---

// 1. Two ways to create an empty string
string methodA = "";            // Using a literal
string methodB = string.Empty; // Using the built-in C# property (Cleaner)

// 2. Checking the length
// This will print '0' because there are no characters inside
Console.WriteLine($"The length is: {methodA.Length}");
Console.WriteLine($"The length is : {methodB.Length}");

// 3. The "Empty" vs "Null" vs "Whitespace" check
string empty = "";
string justSpace = " ";
string? nothing = null;

// Best practice: Use this method to check if a string has any usable text
Console.WriteLine(string.IsNullOrEmpty(empty));     // True
Console.WriteLine(string.IsNullOrWhiteSpace(justSpace)); // True (checks for spaces too)

// 4. Using it as a placeholder
string userResponse = string.Empty; 
// Now we can safely add text to it later without a "null reference" crash
userResponse += "Hello!";