// Use of string.Join in Csharp

string[] hobbies = {"Coding","Gaming","Reading"};
string hobbiesList = string.Join(", ",hobbies); //string join to join the array via , commas 
Console.WriteLine($"My hobbies are: {hobbiesList}");