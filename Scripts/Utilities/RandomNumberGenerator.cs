using UnityEngine;

/// <summary>
/// Class for generating pseudo-random data.
/// </summary>
public static class RandomNumberGenerator
{
    /// <summary>
    /// Return a random integer number between min [inclusive] and max [exclusive].
    /// </summary>
    /// <returns>A pseudo-random number.</returns>
    public static int Generate(int min, int max)
    {
        return Random.Range(min, max);
    }

    /// <summary>
    /// Return a random float number between min [inclusive] and max [exclusive].
    /// </summary>
    /// <returns>A pseudo-random number.</returns>
    public static float Generate(float min, float max)
    {
        return Random.Range(min, max);
    }

    /// <summary>
    /// Return a random int number from attack strength instance.
    /// </summary>
    /// <param name="attackStrength">AttackStrength instance to generate from.</param>
    /// <returns>A pseudo-random number.</returns>
    public static int Generate(AttackStrength attackStrength)
    {
        return Random.Range(attackStrength.AttackStrengthMin, attackStrength.AttackStrengthMax);
    }

    /// <summary>
    /// Return a random zombie number for a specific round with a help of special zombie math functions.
    /// </summary>
    /// <param name="roundNumber">Current zombie round number.</param>
    /// <returns>A pseudo-random number.</returns>
    public static int GenerateZombieNumberForSpecificRound(ZombieRoundNumberModel model)
    {
        var min = ZombieMath.GetMinimumZombieNumberForSpecificRound(model);
        var max = ZombieMath.GetMaximumZombieNumberForSpecificRound(model);
        /*
        Debug.Log("ROUND NUMBER: " + model.RoundNumber);
        Debug.Log("ZOMBIES KILLED: " + model.NumberOfZombiesKilled);
        Debug.Log("PLAYER HEALTH: " + model.PlayerHealthNumber);
        Debug.Log("RND NUMBER 1: " + model.RandomNumberOne);
        Debug.Log("RND NUMBER 2: " + model.RandomNumberTwo);
        Debug.Log("LAST ROUND: " + model.LastRoundZombieCount);
        Debug.Log("MIN: " + min);
        Debug.Log("MAX: " + max);
        */
        var generatedValue = Generate(min, max);

        Debug.Log("GEN VALUE: " + generatedValue);

        var returnValue = model.LastRoundZombieCount + generatedValue;

        Debug.Log("FINAL VALUE: " + returnValue);

        return returnValue;
    }
}