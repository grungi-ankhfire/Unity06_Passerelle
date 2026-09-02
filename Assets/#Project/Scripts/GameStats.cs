using UnityEngine;

public static class GameStats
{
    public static int totalDamage = 0;

    public static void PrintTotalDamage()
    {
        Debug.Log($"You have taken a total of {totalDamage} damage!!");
    }
}
