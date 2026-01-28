List<string> fruits = new List<string> { "Apple", "Banana" };

// 1. Add(value) - Adds an item to the end
fruits.Add("Cherry");

// 2. AddRange(collection) - Adds multiple items at once
fruits.AddRange(new string[] { "Date", "Elderberry" });

// 3. Insert(index, value) - Adds an item at a specific position
fruits.Insert(1, "Blueberry"); // Blueberry is now at index 1

// 4. Remove(value) - Removes the first occurrence of an item
fruits.Remove("Banana");

// 5. RemoveAt(index) - Removes the item at a specific position
fruits.RemoveAt(0); // Removes "Apple"

// 6. Contains(value) - Returns true if the item exists
bool hasDate = fruits.Contains("Date"); // True

// 7. Sort() - Sorts the list alphabetically/numerically
fruits.Sort();

// 8. Clear() - Removes every item from the list
// fruits.Clear();

// 9. Count - Property (not a method) that tells you the size
Console.WriteLine($"List size: {fruits.Count}");

// Printing the list
Console.WriteLine(string.Join(", ", fruits));