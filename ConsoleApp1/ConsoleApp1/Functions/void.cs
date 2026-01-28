// Void function in Csharp
// It does not return any value in return
using System;
using System.Generic.Collections;

public class GameSystem
{
    static int playerHealth = 100;
    public static void Main()
    {
        TakeDamage = 30;
        TakeDamage = 80;
    }
    public static void TakeDamage(int amount)
    {
        playerHealth -= amount;
        Console.WriteLine($"The amount of player taken damage: {amount} and player health is: {playerHealth}");
        if (playerHealth <= 0)
        {
            TriggerGameOver();
        }
    }
    public static void TriggerGameOver()
    {
        Console.WriteLine("Game Over! Starting new game");
        playerHealth = 100;
    }
}