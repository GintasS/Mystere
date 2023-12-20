using System;
using System.Numerics;

/// <summary>
/// Class that handles various zombie math methods.
/// </summary>
public static class ZombieMath
{
    public static int GetMinimumZombieNumberForSpecificRound(ZombieRoundNumberModel model)
    {
        return (int)MinimumEnemyCount(model.RoundNumber, model.RandomNumberOne, model.RandomNumberTwo, model.PlayerHealthNumber);
    }

    public static int GetMaximumZombieNumberForSpecificRound(ZombieRoundNumberModel model)
    {
        return (int)MaximumEnemyCount(model.RoundNumber, model.RandomNumberOne, model.RandomNumberTwo, model.PlayerHealthNumber);
    }

    static double MinimumEnemyCount(double roundNumber, double X_min, double Y_min, double Z_min)
    {
        return X_min + Y_min * roundNumber + Z_min * Math.Sin(Math.PI / 2 * Math.Log(roundNumber));
    }

    static double MaximumEnemyCount(double roundNumber, double X_max, double Y_max, double Z_max)
    {
        return X_max * Math.Cos(Math.PI / 2 + Math.Log(roundNumber)) + Y_max * roundNumber + Z_max / Math.Sqrt(roundNumber);
    }
}