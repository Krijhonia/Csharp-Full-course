using System;

public class StoreSystem
{
    public static void Main()
    {
        // We get a string back from the function and print it
        string finalReceipt = GetDiscountSummary("Laptop", 1200.00, 15);
        Console.WriteLine(finalReceipt);
    }

    // Return Type: string (returns a sentence)
    // Parameters: item name, original price, and the discount percentage
    public static string GetDiscountSummary(string itemName, double price, int discountPercent)
    {
        // 1. Logic: Guard clause (if price is invalid, return an error message immediately)
        if (price <= 0) return "Error: Invalid Price";

        // 2. Calculation: Determine the new price
        double discountAmount = price * (discountPercent / 100.0);
        double finalPrice = price - discountAmount;

        // 3. Transformation: Create a professional string to return
        // We use Math.Round to keep currency neat
        string summary = $"Item: {itemName} | Original: ${price} | After {discountPercent}% Off: ${Math.Round(finalPrice, 2)}";

        return summary; // Return the final string result
    }
}